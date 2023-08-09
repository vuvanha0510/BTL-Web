using System;

namespace Inspire
{
    public partial class EditBlog : System.Web.UI.Page
    {
        readonly long adminID = 28022020;


        protected void Page_Load(object sender, EventArgs e)
        {


            Post mPost;

            String id = Request.QueryString["id"];
            String path = Server.MapPath("App_Data\\blogs.xml");
            mPost = XMLFile.findBlogByID(id, path);
            int userID = (int)Session["id"];

            if (userID != mPost.IdUser && userID != adminID)
            {
                return;
            }
            previewTitle.InnerHtml = mPost.Title;
            previewImage.InnerHtml = "<div class='blog__preview-image'>"
                                    + "<img src = " + mPost.UrlImage + " />"
                                    + "</div>";


        }

        protected void Save_Click(object sender, EventArgs e)
        {
            String id = Request.QueryString["id"];
            String path = Server.MapPath("App_Data\\blogs.xml");
            Post mPost = XMLFile.findBlogByID(id, path);

            mPost.Category = drBanTin.SelectedItem.Value;
            mPost.Title = txtTieuDe.Text;
            mPost.FullBlogHTML = txtNoiDung.Text;
            mPost.Content = preview.Text;
            mPost.UrlImage = xFilePath.Value;


            XMLFile.upDateBlog(mPost, path);
            Response.Redirect("Home.aspx");

        }

        protected void btnUpdate_Click(object sender, EventArgs e)
        {
            previewcontent.Style.Add("display", "none");
            ndcontent.Style.Add("display", "block");
            Post mPost;

            String id = Request.QueryString["id"];
            String path = Server.MapPath("App_Data\\blogs.xml");
            mPost = XMLFile.findBlogByID(id, path);
            int userID = (int)Session["id"];

            if (userID != mPost.IdUser && userID != adminID)
            {
                return;
            }

            drBanTin.SelectedItem.Value = mPost.Category;
            txtTieuDe.Text = mPost.Title;
            txtNoiDung.Text = mPost.FullBlogHTML;
            preview.Text = mPost.Content;
            xFilePath.Value = mPost.UrlImage;
        }

        protected void FileBrowser2_Load(object sender, EventArgs e)
        {
            FileBrowser2 = new CKFinder.FileBrowser();
            FileBrowser2.BasePath = "/ckfinder/ckfinder/";
            FileBrowser2.SetupCKEditor(txtNoiDung);
        }
    }
}