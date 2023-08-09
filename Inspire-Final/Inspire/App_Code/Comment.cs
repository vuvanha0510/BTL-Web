using System;

namespace Inspire
{
    public class Comment
    {
        private long postID;
        private String value;
        private String userName;
        //private String time;

        public Comment()
        {

        }

        public Comment(long postID, String value, String userName/*, string DateTime*/)
        {
            this.postID = postID;
            this.value = value;
            this.userName = userName;
            //this.time = time;
        }

        public long PostID
        {
            get
            {
                return postID;
            }

            set
            {
                postID = value;
            }
        }

        public string Value
        {
            get
            {
                return value;
            }

            set
            {
                this.value = value;
            }
        }

        public string UserName
        {
            get
            {
                return userName;
            }

            set
            {
                userName = value;
            }
        }

        /*public String Time
        {
            get
            {
                return time;
            }

            set
            {
                time = value;
            }

        }*/

        public String getHTML()
        {
            //string time = DateTime.Now.ToString();
            String html = "";
            html += "<div class =\"comment\">"
                 + "<div class=\"commentAvatar\">"
                 + "<img src = \"Images/image_user.png \">"
                 + "</div>"
                 + "<p><b>" + userName + "</b></p>"
                 + "<p>" + value + "</p>"
                 //+ "<p>" + time + "</p>" 
                 + "</div>";
            return html;
        }
    }
}