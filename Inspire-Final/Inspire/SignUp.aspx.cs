using System;
using System.Collections.Generic;
using System.Web.UI.WebControls;

namespace Inspire
{
    public partial class SignUp : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if ((bool)Session["login"] == true)
            {
                Response.Redirect("Home.aspx");
            }

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            String path = Server.MapPath("App_Data\\members.xml");
            List<Member> list = XMLFile.getListMember(path);

            Member mb = new Member();
            mb.NickName = myUsername.Value.ToString();
            mb.Email = myEmail.Value.ToString();
            mb.Password = myPassword.Value.ToString();
            XMLFile.addMemberToList(mb, path);
            if (!myEmail.Value.ToString().Equals(myPassword.Value.ToString()))
            {
                return;
            }
            

            bool addMember = XMLFile.addMemberToList(mb, path);


            /*if (addMember)
            {

                Response.Redirect("SignIn.aspx");
            }
            else
            {
                thongbao.InnerText = "Tài khoản đã tồn tại!";
            }*/










            if (addMember == true)
              {
                  //Tạo session
                  Session["login"] = true;
                  Session["id"] = mb.Id;
                  Session["nickname"] = mb.NickName;
                  Session["email"] = mb.Email;
                  Session["password"] = mb.Password;

                  if ((bool)Session["login"] == true)
                  {
                      Response.Redirect("SignIn.aspx");
                  }
              }
              else
              {
                  Response.Write("<script>alert('Your Account is Existed !');</script>");
              }



        }



        protected void CustomValidator1_ServerValidate(object source, ServerValidateEventArgs args)
        {

            args.IsValid = false;
            if (myPassword.Value.ToString().Equals(myRePassword.Value.ToString()))
            {
                args.IsValid = true;
            }
        }


    }
}