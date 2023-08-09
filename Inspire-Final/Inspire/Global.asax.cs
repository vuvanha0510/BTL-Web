using System;
using System.Collections;

namespace Inspire
{
    public class Global : System.Web.HttpApplication
    {

        protected void Application_Start(object sender, EventArgs e)
        {
            Application["soNguoiTruyCap"] = 0;
            Application["tongSoTruyCap"] = 0;
            Application["lst_soNguoiTruyCapBlog"] = new Hashtable();
        }
        protected void Session_Start(object sender, EventArgs e)
        {

            Session["login"] = false;
            Session["id"] = "";
            Session["nickname"] = "";
            Session["email"] = "";
            Session["password"] = "";
            Application["soNguoiTruyCap"] = (int)Application["soNguoiTruyCap"] + 1;
        }

        protected void Application_BeginRequest(object sender, EventArgs e)
        {

        }

        protected void Application_AuthenticateRequest(object sender, EventArgs e)
        {

        }

        protected void Application_Error(object sender, EventArgs e)
        {


        }

        protected void Session_End(object sender, EventArgs e)
        {
            Application["soNguoiTruyCap"] = (int)Application["soNguoiTruyCap"] - 1;

        }

        protected void Application_End(object sender, EventArgs e)
        {

        }

    }
}