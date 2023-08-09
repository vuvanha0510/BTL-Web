<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="FullBlog.aspx.cs" Inherits="Inspire.FullBlog" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <link href="Styles/FullBlog.css" rel="stylesheet" />
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="container">
       <div class="row">
        <div class="fullblog ">
            <h3 id="title" runat="server" class="fullblog__title"></h3>
            <p id="author" runat="server"></p>
            <asp:Label id="soLuotXem" runat="server" Text="Label" ForeColor="Red"></asp:Label>
            <p id="tongSoLuotXem" runat="server" Text="Label" ForeColor="Red"></p>
            <div id="thumb" runat="server">
            </div>

            <div id="content" runat="server" class="fullblog__content">

            </div>
            
            <div id="comments" >

                <div id="newComment">
                    <asp:Label ID="checkError" runat="server" Text="Label" ForeColor="Red"></asp:Label>
                    <br />
                    <label for="yourName">Your Name</label>
                    <asp:TextBox ID="yourName" runat="server"></asp:TextBox>
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="yourName" ErrorMessage="Bạn chưa nhập tên" ForeColor="#FF3300"></asp:RequiredFieldValidator>
                    <br />
                    <label for="yourComment">Your Comment</label>
                    <br />
                    <textarea id="yourComment" runat="server" rows="5" cols="100"></textarea>
                    <br />
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" ControlToValidate="yourComment" ErrorMessage="Chưa nhập dữ liệu " ForeColor="Red" ></asp:RequiredFieldValidator>
                    <asp:Button ID="Button1" runat="server" Text="SEND" OnClick="Button1_Click" />

                </div>
                
                <h3>COMMENTS</h3>
                <div id="CMTContent" runat="server">
                     <div class ="comment">
                        <div class="commentAvatar">
                        <img src="https://scontent-hkg4-1.xx.fbcdn.net/v/t1.0-9/27973391_2282495288640722_9050996645891025864_n.jpg?_nc_cat=101&_nc_sid=13bebb&_nc_ohc=LX3ETBfkHrgAX-1D3_x&_nc_ht=scontent-hkg4-1.xx&oh=1b2e8946af5e2a3345d8b9577bb02ea5&oe=5EC71D9E" />
                        </div>
                     <p> <b>DangRED</b></p>
                     <p>Blog hay lắm!</p>
                    </div>
               </div> 
               
            </div>

          
        </div>  
        <div class="fullblog__sidebar">
            <div class="fullblog__popular">
                <h3>Popular Post</h3> 
                <div class="popular__block clearfix">
                    <div class="popular__left">
                        <img src="Images/popular.jpg" alt="Alternate Text" />
                    </div>
                    <div class="popular__right">
                        <a href="#">6 Best WordPress Landing Page Plugins Compared (2020)</a>
                        <p>Posted by <span>Antondev</span></p>
                    </div>
                </div>

                 <div class="popular__block clearfix">
                    <div class="popular__left">
                        <img src="Images/popular4.png" alt="Alternate Text" />
                    </div>
                    <div class="popular__right">
                        <a href="#">Homepage Headlines in the Heart of the Hero Area</a>
                        <p>Posted by <span>Chienpanda</span></p>
                    </div>
                </div>

                 <div class="popular__block clearfix">
                    <div class="popular__left">
                        <img src="Images/popular3.png" alt="Alternate Text" />
                    </div>
                    <div class="popular__right">
                        <a href="#">A Trend to Follow – Headline-Centric Hero Areas</a>
                        <p>Posted by <span>Dangblack</span></p>
                    </div>
                </div>

                <div class="popular__block clearfix">
                    <div class="popular__left">
                        <img src="Images/post-image1.png" alt="Alternate Text" />
                    </div>
                    <div class="popular__right">
                        <a href="#">Big and Bold Typography: A New Trend in Web Design</a>
                        <p>Posted by <span>Dangblack</span></p>
                    </div>
                </div>

                <div class="popular__block clearfix">
                    <div class="popular__left">
                        <img src="Images/popular2.jpg" alt="Alternate Text" />
                    </div>
                    <div class="popular__right">
                        <a href="#">Logo Package Express: Making Logo Design Packaging a Breeze</a>
                        <p>Posted by <span>Dangblack</span></p>
                    </div>
                </div>
            </div>
         </div>
        </div>
     </div>
</asp:Content>
