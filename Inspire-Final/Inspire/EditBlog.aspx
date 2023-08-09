<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="EditBlog.aspx.cs" Inherits="Inspire.EditBlog" %>
 <%@ Register Assembly="CKEditor.NET" Namespace="CKEditor.NET" TagPrefix="CKEditor" %>
<%@ Register Namespace="CKFinder" Assembly="CKFinder" TagPrefix="CKFinder" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <link href="Styles/EditBlog.css" rel="stylesheet" />
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="blog__preview blog" id="previewcontent" runat="server">
        <h2 id="previewTitle" runat="server" class="fullblog__title"></h2>
        <div id="previewImage" runat="server">
        </div>
        <asp:Button runat="server" id="btnUpdate" OnClick="btnUpdate_Click" Text="Chỉnh sửa" CssClass="blog__submit">
        </asp:Button>
    </div>
    <div class="container">
    <div id="ndcontent" class="blog" runat="server" style="display:none;">
        <div class="blog__block">
               <h4>Chuyên mục</h4>
              <asp:DropDownList ID="drBanTin" runat="server" CssClass="blog__item">
                  <asp:ListItem Value="">Please Select</asp:ListItem>  
                  <asp:ListItem>Programing</asp:ListItem>  
                  <asp:ListItem>Lifestyle</asp:ListItem>  
                  <asp:ListItem>Entertainment</asp:ListItem>  
              </asp:DropDownList>
        </div>
        <div class="blog__block">
             <h4>Tiêu đề bản tin:</h4>
             <asp:TextBox ID="txtTieuDe" runat="server" CssClass="blog__item"></asp:TextBox>
        </div>
         <div class="blog__block">
             <h4>Hình ảnh đại diện</h4>
                <input id="xFilePath" name="FilePath" type="text" class="blog__item" runat="server"/> 
                <input type="button" value="Browse Server" onclick="BrowseServer();" class="controls" />
                 <script type="text/javascript">
                     function BrowseServer() {
                         var finder = new CKFinder();
                         finder.basePath = "/ckfinder/ckfinder/";
                         finder.selectActionFunction = SetFileField;
                         finder.popup();
                     }
                     function SetFileField(fileUrl) {
                         document.getElementById("<%=xFilePath.ClientID%>").value = fileUrl;
                     }
                 </script>
        </div>
         <div class="blog__block">
              <h4>Preview</h4>
              <asp:TextBox ID="preview" runat="server" CssClass="blog__item"></asp:TextBox>
        </div>
         <div class="blog__block">
             <h4>Nội dung bản tin:</h4>
              <CKEditor:CKEditorControl ID="txtNoiDung" runat="server" style="width:50rem;" >
              </CKEditor:CKEditorControl>
        </div>
         <div class="blog__block">
            <asp:Button ID="Save" runat="server" OnClick="Save_Click" Text="Cập nhật" CssClass="blog__submit" />
        </div>
    </div>
   </div>
   <CKFinder:FileBrowser ID="FileBrowser2" Width="0" runat="server" OnLoad="FileBrowser2_Load"></CKFinder:FileBrowser>

</asp:Content>
