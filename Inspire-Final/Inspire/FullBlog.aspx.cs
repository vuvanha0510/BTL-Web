using System;
using System.Collections;
using System.Collections.Generic;

namespace Inspire
{
    public partial class FullBlog : System.Web.UI.Page
    {

        protected void Page_Load(object sender, EventArgs e)
        {
            checkError.Text = "";
            String id = Request.QueryString["id"];
            String path = Server.MapPath("App_Data\\blogs.xml");
            Post mPost = XMLFile.findBlogByID(id, path);
            title.InnerText = mPost.Title;
            author.InnerHtml = "<p class='fullblog__author'>" +
                                "<span>Posted by </span>" + mPost.Author
                                + "</p>";
            thumb.InnerHtml = "<div class='fullblog__thumb'>" +
                                         "<img src = " + mPost.UrlImage + " />" +
                                         "</div>";
            content.InnerHtml = mPost.FullBlogHTML;


            // cmt
            String CMTPath = Server.MapPath("App_Data\\Comments.xml");
            List<Comment> cmts = XMLFile.getCommentsByID(int.Parse(id), CMTPath);
            String cmtsHTML = "";
            foreach (Comment cmt in cmts)
            {
                cmtsHTML += cmt.getHTML();
            }
            CMTContent.InnerHtml = cmtsHTML;

            //loadViewBlog
            loadViewBlog();
        }


        protected void Button1_Click(object sender, EventArgs e)
        {
            String id = Request.QueryString["id"];
            Hashtable viewBlog = (Hashtable)Application["lst_soNguoiTruyCapBlog"];
            viewBlog[id] = (int)viewBlog[id] - 1;

            String name = yourName.Text;
            String cmt = yourComment.Value.ToString();
            
            String CMTPath = Server.MapPath("App_Data\\Comments.xml");

            Comment comment = new Comment(int.Parse(id), cmt, name);

            XMLFile.addCMT(comment, CMTPath);
            yourName.Text = "";
            yourComment.Value = "";
            
            Page_Load(sender, e);


        }


        protected void loadViewBlog()
        {
            String id = Request.QueryString["id"];
            Hashtable viewBlog = (Hashtable)Application["lst_soNguoiTruyCapBlog"];
            if (viewBlog[id] == null)
            {
                viewBlog.Add(id, 0);
            }
            viewBlog[id] = (int)viewBlog[id] + 1;
            soLuotXem.Text = "Tổng lượt xem:" + (int)viewBlog[id];
            tongSoLuotXem.InnerText = "Tổng lượt xem:" + (int)viewBlog[id];
        }


    }
}