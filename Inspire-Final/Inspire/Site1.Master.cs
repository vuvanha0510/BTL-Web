using System;

namespace Inspire
{
    public partial class Site1 : System.Web.UI.MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string html = "";
            html += "<a href='SignUp.aspx' class='btn btn--signup'>Sign up</a>"
                    + "<a href ='SignIn.aspx' class='btn btn--login'>Login</a>";

            if ((bool)Session["login"] == true && (string)Session["nickname"] == "admin")
            {
                loginserver.InnerHtml = "<a href='Blog.aspx' class='btn btn--signup'>Create Blog</a>"
                                      + "<a href='AdminAccount.aspx' class='btn'>Accounts</a>"
                                      + "<a href='#' class='btn btn--login'>"
                                      + "<form><button type='submit' class='btnLogout' value='true' name='btnLogout' id='btnLogout' runat='server'>"
                                      + "Logout</button></form>"
                                      + "</a>";

            }


            else if ((bool)Session["login"] == true)
            {
                loginserver.InnerHtml = "<a href='Blog.aspx' class='btn btn--signup'>Create Blog</a>"
                                      + "<a href='#' class='btn btn--login'>"
                                      + "<form><button type='submit' class='btnLogout' value='true' name='btnLogout' id='btnLogout' runat='server'>"
                                      + "Logout</button></form>"
                                      + "</a>";

            }
            else
            {
                loginserver.InnerHtml = html;
            }

            if (Request.QueryString["btnLogout"] == "true")
            {
                Session.Abandon();

                Response.Redirect("SignUp.aspx");
            }
        }
    }
}