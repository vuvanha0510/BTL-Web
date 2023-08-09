using System;
using System.Collections.Generic;

namespace Inspire
{
    public partial class Home : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
           
            String path = Server.MapPath("App_Data\\blogs.xml");
            List<Post> postList = XMLFile.getListBlogInXML(path);
            String disPlay = "";
            for (int i = postList.Count - 1; i >= 0; i--)
            {
                disPlay += postList[i].getHtml();
            }
            homeContent.InnerHtml = disPlay;
            

        }
    }
}