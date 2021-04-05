<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm2.aspx.cs" Inherits="WebApplication5.WebForm2" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
       <style>
           .btn{
               background-color:red;
           }
    </style>
</head>
<body>
    <form runat="server">
    <asp:Label ID="Label1" runat="server" Text="Label"></asp:Label>  
   
        <asp:FileUpload  runat="server" ID="fileupload"/>
         <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
    <asp:Button ID="Button1" runat="server" Text="Button" OnClick="Button1_Click" />

        <asp:Button ID="Button2" CssClass="btn" runat="server" Text="Button" />
    </form>
   
</body>
 
</html>
