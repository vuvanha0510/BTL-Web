<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="SignUp.aspx.cs" Inherits="Inspire.SignUp" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <link href="Styles/SignUp.css" rel="stylesheet" />
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="main">
    <div class="signup clearfix" >
        <div class="signup__left" >
           <h3>Sign up</h3>
           <h3 id="thongbao" runat="server" style="color:red"></h3>

           <div class="signup__group">
               <i class="fas fa-user"></i>
               <input runat="server" type="text" name="txtUsername" id="myUsername" placeholder="Your name..." class="signup__input"/>
               <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="myUsername" ErrorMessage="Bạn chưa nhập tên!" ForeColor="Red" ></asp:RequiredFieldValidator>

           </div>
           <div class="signup__group">
               <i class="fas fa-envelope"></i>
               <input runat="server"  type="email" name="txtEmail" id="myEmail" placeholder="Your email..." class="signup__input"/>
               <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ControlToValidate="myEmail" ErrorMessage="Bạn chưa nhập email!" ForeColor="Red" ></asp:RequiredFieldValidator>

           </div>
           <div class="signup__group">
               <i class="fas fa-lock"></i>
               <input runat="server"  type="password" name="txtPassword" id="myPassword" placeholder="Password..." class="signup__input"/>
               <asp:CustomValidator ID="CustomValidator1" runat="server" ForeColor="Red" ErrorMessage="Mật khẩu phải giống nhau" ClientValidationFunction="myPassword" OnServerValidate="CustomValidator1_ServerValidate"></asp:CustomValidator>
           </div> 
            <div class="signup__group">
                <i class="fas fa-passport"></i>
                <input runat="server" type="password" name="txtRePassword" id="myRePassword" placeholder="Repeat your Password..." class="signup__input"/>
               <asp:RequiredFieldValidator ID="RequiredFieldValidator4" runat="server" ControlToValidate="myRePassword" ErrorMessage="Bạn chưa nhập mật khẩu!" ForeColor="Red" ></asp:RequiredFieldValidator>
           </div> 
            
         
            <div class="signup__block">
                <asp:Button ID="btn123" runat="server" Text="Đăng Ký" OnClick="Button1_Click" CssClass="btnSign"/>
            </div> 
            <a href="SignIn.aspx">Đã có tài khoản? Đăng nhập </a>
        </div>  
    </div>
    </div>
</asp:Content>
