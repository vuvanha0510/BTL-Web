using System;
using System.Collections.Generic;
using System.IO;
using System.Web.UI;
using System.Xml.Serialization;

namespace Inspire
{
    public partial class YourBlogs : System.Web.UI.Page
    {
        readonly long adminID = 28022020;

        protected void Page_Load(object sender, EventArgs e)
        {
            if ((bool)Session["login"] == false)
            {
                Response.Write("<script>alert('Bạn chưa đăng nhập blog !');</script>");
                Response.Redirect("SignIn.aspx");
            }

            long id = (int)Session["id"];

            String path = Server.MapPath("App_Data\\blogs.xml");
            List<Post> postList = XMLFile.getListBlogInXML(path);
            String disPlay = "";
            int dem = 0;
            if (id == adminID)
            {
                foreach (Post x in postList)
                {
                    disPlay += x.getDisPlayYourBlogHTML();
                    dem++;
                }
                rowContent.InnerHtml = "<h3> Số blog của bạn:" + dem + "</h3>" + disPlay;
            }
            else
            {
                foreach (Post x in postList)
                {
                    if (x.IdUser == id)
                    {
                        dem++;
                        disPlay += x.getDisPlayYourBlogHTML();
                    }

                }
                rowContent.InnerHtml = "<h3> Số blog của bạn:" + dem + "</h3>" + disPlay;
            }




            //Xoa bai viet
            foreach (Post x in postList)
            {
                if (Request.Form["btnXoa"] == Convert.ToString(x.BlogID))
                {
                    postList.Remove(x);
                    //Ghi file
                    XmlSerializer writer = new XmlSerializer(typeof(List<Post>));
                    FileStream filecreate = File.Create(path);
                    writer.Serialize(filecreate, postList);
                    filecreate.Close();

                    Page.Response.Redirect(Page.Request.Url.ToString(), true);
                    break;
                }
            }

        }
    }
}