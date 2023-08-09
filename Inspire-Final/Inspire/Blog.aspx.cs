using System;

namespace Inspire
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {


        }


        protected void Save_Click1(object sender, EventArgs e)
        {

            Post mPost = new Post();
            mPost.Category = drBanTin.SelectedItem.Value;
            mPost.Title = txtTieuDe.Text;
            mPost.UrlImage = xFilePath.Value.ToString();
            mPost.Content = txtPreview.Text;
            mPost.FullBlogHTML = txtNoiDung.Text;
            mPost.Author = (string)Session["nickname"];
            mPost.BlogID = new Random().Next(100000, 999999);
            mPost.IdUser = (int)Session["id"];
            String path = Server.MapPath("App_Data\\blogs.xml");
            if (mPost.Category == "")
            {
                string alert = "";
                alert += "<script>alert('Ban phai chon chuyen muc !');</script>";
                Response.Write(alert);
            }
            if (mPost.Title == "")
            {
                string alert = "";
                alert += "<script>alert('Ban phai nhap tieu de !');</script>";
                Response.Write(alert);
            }
            if (mPost.Content.Length < 30)
            {
                string alert = "";
                alert += "<script>alert('Ban phai nhap noi dung lon hon 30 ki tu!');</script>";
                Response.Write(alert);
            }
            else
            {
            XMLFile.addBlog(mPost, path);
            Response.Redirect("Home.aspx");
            }
            
        }
        protected void FileBrowser1_Load(object sender, EventArgs e)
        {
            FileBrowser1 = new CKFinder.FileBrowser();
            FileBrowser1.BasePath = "/ckfinder/ckfinder/";
            FileBrowser1.SetupCKEditor(txtNoiDung);
        }
    }
}