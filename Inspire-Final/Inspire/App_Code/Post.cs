namespace Inspire
{
    public class Post
    {
        private string urlImage;
        private string category;
        private string title;
        private string content;
        private string author;
        private long id;
        private string fullBlogHTML;
        private long idUser;

        public long BlogID { get { return id; } set { id = value; } }
        public string UrlImage { get { return urlImage; } set { urlImage = value; } }
        public string Category { get { return category; } set { category = value; } }
        public string Title { get { return title; } set { title = value; } }
        public string Content { get { return content; } set { content = value; } }
        public string Author { get { return author; } set { author = value; } }

        public long IdUser { get { return idUser; } set { idUser = value; } }

        public string FullBlogHTML { get { return fullBlogHTML; } set { fullBlogHTML = value; } }

        public string getHtml()
        {

            string htmlString;
            htmlString =
                        "<div class='post__image'>"
                       + "<img src = " + UrlImage + " />"
                       + "</div>"
                       + "<div class='post__content'>"
                       + "<h4>" + Category + "</h4>"
                       + "<h2 class='post__title'> " + Title + "</h2> "
                       + "<p class='post__desc'>" + Content + "</p>"
                       + "<p class='post__author'>" + Author + "</p>"
                       + "</div>";


            return "<a href=FullBlog.aspx?id=" + id + " class='linkpost' >" + htmlString + "</a>";
        }
        public string getDisPlayYourBlogHTML()
        {
            string htmlString;
            htmlString = "<div class='yourblog clearfix'>"
                           + "<div class='yourblog__image'>"
                           + "<img src = " + UrlImage + " />"
                           + "</div>"
                           + "<div class='yourblog__content'>"
                           + "<h2>" + Title + "</h2>"
                           + "<p>" + Author + "</p>"
                           + "</div>"
                           + "<br>"
                           + "<button type=\"submit\" value=\"" + id + "\" class=\"btn btnDelete\" name=\"btnXoa\">" +
                               "<i class=\"fa fa-trash\" aria-hidden=\"true\"></i>Delete</button>"
                            + "</div>";

            return "<a href=EditBlog.aspx?id=" + id + ">" + htmlString + "</a>";
        }
    }
}