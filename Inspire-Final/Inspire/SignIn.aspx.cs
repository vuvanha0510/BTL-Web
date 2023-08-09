using System;
using System.Collections.Generic;

namespace Inspire
{
    public partial class SignIn : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if ((bool)Session["login"] == true)
            {
                Response.Redirect("Home.aspx");
            }
        }

        protected void btnSubmit_Click(object sender, EventArgs e)
        {
            string path = (Server.MapPath("App_Data\\members.xml"));
            List<Member> list = XMLFile.getListMember(path);

            Member mb = new Member();
            mb.Id = list.Count;
            mb.NickName = inputUsername.Value.ToString();
            mb.Password = inputPassword.Value.ToString();

            if (XMLFile.checkMemberSignIn(mb, path))
            {
                string alert = "";
                alert += "<script>alert('Your username or password not correct !');</script>";
                Response.Write(alert);
            }
            else
            {
                //Tạo session
                Session["login"] = true;
                Session["id"] = mb.Id;
                Session["nickname"] = mb.NickName;
                Session["password"] = mb.Password;
            }

            if ((bool)Session["login"] == true)
            {
                Response.Redirect("Home.aspx");
            }

        }
    }
}