<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="login.aspx.cs" Inherits="WebApplication5.login" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
   <form id="form1" runat="server">  
    <p>Provide Following Details</p>  

       <asp:GridView ID="GridView1" runat="server"></asp:GridView>
    <table class="auto-style1">  
        <tr>  
            <td class="auto-style2">Email</td>  
            <td>  
                <asp:TextBox ID="email" runat="server" TextMode="Email" OnTextChanged="email_TextChanged" AutoPostBack="true"></asp:TextBox>  
                <asp:Label ID="Label1" runat="server" Text="Label"></asp:Label>
            </td>  
        </tr>  
        <tr>  
            <td class="auto-style2">Password</td>  
            <td>  
                <asp:TextBox ID="password" runat="server" TextMode="Password" ></asp:TextBox>  
            </td>  
        </tr>  
        <tr>  
            <td class="auto-style2"> </td>  
            <td>  
                <asp:Button ID="Button1" runat="server" Text="Button"  OnClick="login_Click"/>
            </td>  
        </tr>  
    </table>  
    <br />  
    <asp:Label ID="Label3" runat="server"></asp:Label>  
    <br />  
    <asp:Label ID="Label4" runat="server"></asp:Label>  
</form>  
</body>
</html>
