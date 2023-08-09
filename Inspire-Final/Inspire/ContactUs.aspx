<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="ContactUs.aspx.cs" Inherits="Inspire.ContactUs" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <link rel="stylesheet" href="Styles/ContactStyles.Css"/>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
   
    <div class="Contact__Header">
        <header>
            <h1>Contact Us</h1>
        </header>
    </div> 
    <div class="container">
    <div class="Contact__container">  
        <div class="content">
                <h1>Let's start something great</h1>
                <h3>Please fill out the form below. Your message will be confidentially sent to the team. 
                    It will be placed at the top of the stack 
                    and we will respond to you today.</h3>
         </div>
        <div class="main-container clearfix">
          
            
            <div class="Container_form_right">
                
                <form action="#" id="frmContact">
                    
                    <div class="_1row">
                        <label for="Name">First Name<span style="color: red;">*</span></label>
                            <br>
                            <input type="text" id="Name">   
                    </div>
                    <div class="_1row">
                        <label for="Name">Last Name<span style="color: red;">*</span></label>
                            <br>
                            <input type="text" id="Name">
                            <br> 
                    </div>
                    <div class="_1row">

                        <br>
                        <br>
                        <label for="Name">What is your email address?<span style="color: red;">*</span></label>
                        <br>
                        <input type="text" id="Name">
                        <br>
                    </div>
                    
                    <div class="_1row">
                        <label for="Name">How can we help you? <span style="color: red;">*</span></label>
                        <br>
                        <textarea name="text" id="opinion" cols="100" rows="10"></textarea>
                        <br>
                        <div class="button">
                            <button>Submit</button>
                        </div>
                    </div>
                    
                </form>
            </div>
            
        </div>
    </div>
    </div>
</asp:Content>
