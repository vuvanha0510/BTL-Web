<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="SignIn.aspx.cs" Inherits="Inspire.SignIn" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
      <link href="Styles/SignUp.css" rel="stylesheet" />
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="main">
    <div class="signup clearfix">
        <div class="signup__right">
            
            <a href="SignUp.aspx">Create an account</a>
        </div>
        <div class="signup__left">
           <h3>Sign in</h3>
           <div class="signup__group">
               <i class="fas fa-user"></i>
               <input  type="text" name="txtUsername" id="inputUsername" placeholder="Your name..." class="signup__input" runat="server"/>
               <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="inputUsername" ErrorMessage="Bạn chưa nhập tên đăng nhập !" ForeColor="Red" ></asp:RequiredFieldValidator>

           </div>
           <div class="signup__group">
               <i class="fas fa-lock"></i>
               <input  type="password" name="txtPassword" id="inputPassword" placeholder="Password..." class="signup__input" runat="server"/>
               <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" ControlToValidate="inputPassword" ErrorMessage="Bạn chưa nhập mật khẩu !" ForeColor="Red" ></asp:RequiredFieldValidator>

           </div> 
           <div class="signup__block">
                <input type="checkbox" id="myCheckbox" class="signup__input"/>
                <label for="myCheckbox"> Remember me</label>
           </div> 
            <div class="signup__block">
                <asp:Button ID="btnSubmit" runat="server" Text="Submit" Width="100px" CssClass="btnSign" OnClick="btnSubmit_Click" />
            </div>
            
        </div>
       
    </div>
   </div>
</asp:Content>
