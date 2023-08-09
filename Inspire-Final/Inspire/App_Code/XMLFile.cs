using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

/* Unmerged change from project '19_App_Code'
Before:
using System.Linq;
using System.Web;
After:
using System.Web;
using System.Xml.Serialization;
*/
using System.Xml.Serialization;

namespace Inspire
{
    public class XMLFile
    {
        public static List<Post> getListBlogInXML(String path)
        {
            // Đọc file
            List<Post> list;
            System.Xml.Serialization.XmlSerializer reader = new System.Xml.Serialization.XmlSerializer(typeof(List<Post>));
            StreamReader file = new StreamReader(path);

            list = (List<Post>)reader.Deserialize(file);
            file.Close();
            return list;
        }

        public static void addBlog(Post ob, String path)
        {
            List<Post> mList = null;

            mList = getListBlogInXML(path);

            if (mList == null)
            {
                mList = new List<Post>();
            }
            mList.Add(ob);
            //Ghi file
            //Ghi file
            XmlSerializer writer = new XmlSerializer(typeof(List<Post>));

            System.IO.FileStream _file = System.IO.File.Create(path);

            writer.Serialize(_file, mList);
            _file.Close();

        }

        public static void upDateBlog(Post ob, String path)
        {
            List<Post> mList = null;

            mList = getListBlogInXML(path);

            if (mList == null)
            {
                return;
            }

            for (int i = 0; i < mList.Count; i++)
            {
                if (mList[i].BlogID == ob.BlogID)
                {
                    mList[i] = ob;
                    break;
                }

            }
            //Ghi file
            //Ghi file
            XmlSerializer writer = new XmlSerializer(typeof(List<Post>));

            System.IO.FileStream _file = System.IO.File.Create(path);

            writer.Serialize(_file, mList);
            _file.Close();

        }

        public static Post findBlogByID(String id, String path)
        {
            List<Post> list = getListBlogInXML(path);
            long idLong = int.Parse(id);

            foreach (Post x in list)
            {
                if (x.BlogID == idLong)
                    return x;
            }
            return new Post();

        }

        public static List<Member> getListMember(String path)
        {

            if (File.Exists(path))
            {
                List<Member> list;
                // Đọc file
                XmlSerializer reader = new XmlSerializer(typeof(List<Member>));
                StreamReader file = new StreamReader(path);

                list = (List<Member>)reader.Deserialize(file);
                list = list.OrderBy(Member => Member.Id).ToList();
                file.Close();
                return list;

            }
            return new List<Member>();
        }

        public static bool checkMemberSignIn(Member newMember, String path)
        {
            List<Member> list = getListMember(path);

            foreach (Member mem in list)
            {
                if (mem.NickName.Equals(newMember.NickName) && mem.Password.Equals(newMember.Password))
                {

                    newMember.Id = mem.Id;
                    return false;
                }
            }
            return true;
        }

        public static bool addMemberToList(Member member, String path)
        {

            List<Member> list = getListMember(path);

            //Kiểm tra tên đã tồn tại hay chưa;
            bool hasMember = false;
            foreach (Member mem in list)
            {
                if (mem.NickName.Equals(member.NickName))
                {
                    hasMember = true;
                    break;
                }
            }

            if (!hasMember)
            {
                member.Id = new Random().Next(100000, 999999);
                list.Add(member);
                //Ghi file
                XmlSerializer writer = new XmlSerializer(typeof(List<Member>));
                FileStream filecreate = File.Create(path);
                writer.Serialize(filecreate, list);
                filecreate.Close();
                return true;
            }
            return false;

        }
        public static List<Comment> getCommentsByID(long id, String path)
        {
            // Đọc file
            List<Comment> list;
            System.Xml.Serialization.XmlSerializer reader = new System.Xml.Serialization.XmlSerializer(typeof(List<Comment>));
            StreamReader file = new StreamReader(path);

            list = (List<Comment>)reader.Deserialize(file);

            file.Close();

            List<Comment> list2 = new List<Comment>();
            foreach (Comment cmt in list)
            {
                if (cmt.PostID == id)
                {
                    list2.Add(cmt);
                }
            }

            return list2;
        }

        public static void addCMT(Comment comment, String path)
        {

            List<Comment> list;
            System.Xml.Serialization.XmlSerializer reader = new System.Xml.Serialization.XmlSerializer(typeof(List<Comment>));
            StreamReader file = new StreamReader(path);

            list = (List<Comment>)reader.Deserialize(file);

            file.Close();
            list.Add(comment);
            //Ghi file
            XmlSerializer writer = new XmlSerializer(typeof(List<Comment>));
            FileStream filecreate = File.Create(path);
            writer.Serialize(filecreate, list);
            filecreate.Close();
        }


    }
}