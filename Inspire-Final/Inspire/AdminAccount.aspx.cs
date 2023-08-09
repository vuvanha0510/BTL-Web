using System;
using System.Collections.Generic;
using System.IO;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Xml.Serialization;

namespace Inspire
{
    public partial class AdminAccount : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if ((string)Session["nickname"] != "admin" || (bool)Session["login"] == false)
            {
                Response.Redirect("Home.aspx");
            }
            String path = Server.MapPath("App_Data\\members.xml");
            List<Member> list = XMLFile.getListMember(path);
            Table_load();

            foreach (Member mb in list)
            {
                if (Request.Form["btnXoa"] == Convert.ToString(mb.Id))
                {
                    if (mb.Id == 28022020)
                    {
                        string alert = "";
                        alert += "<script>alert('You cannot delete Admin account !');</script>";
                        Response.Write(alert);
                    }
                    else
                    {
                        list.Remove(mb);
                        //Ghi file
                        XmlSerializer writer = new XmlSerializer(typeof(List<Member>));
                        FileStream filecreate = File.Create(path);
                        writer.Serialize(filecreate, list);
                        filecreate.Close();

                        Page.Response.Redirect(Page.Request.Url.ToString(), true);
                        break;
                    }

                }
            }
        }

        private void Table_load()
        {
            String path = Server.MapPath("App_Data\\members.xml");
            List<Member> memberList = XMLFile.getListMember(path);
            int dem = 0;
            foreach (Member mb in memberList)
            {
                dem++;
                TableRow row = new TableRow();

                TableCell cId = new TableCell();
                cId.Text = Convert.ToString(mb.Id);
                row.Cells.Add(cId);

                TableCell cNickname = new TableCell();
                cNickname.Text = Convert.ToString(mb.NickName);
                row.Cells.Add(cNickname);

                TableCell cEmail = new TableCell();
                cEmail.Text = Convert.ToString(mb.Email);
                row.Cells.Add(cEmail);

                TableCell cPass = new TableCell();
                cPass.Text = Convert.ToString(mb.Password);
                row.Cells.Add(cPass);

                string html = "<button type=\"submit\" value=\"" + mb.Id + "\" class=\"btn\" name=\"btnXoa\">" +
                               "<i class=\"fa fa-trash\" aria-hidden=\"true\"></i>Delete</button>";
                TableCell cButton = new TableCell();
                cButton.Text = html;
                row.Cells.Add(cButton);

                table.Rows.Add(row);
            }


        }
    }
}