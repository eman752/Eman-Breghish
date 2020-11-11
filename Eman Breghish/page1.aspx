<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="page1.aspx.cs" Inherits="Eman_Breghish.page1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <asp:TextBox ID="TextBox1" runat="server" Width="200px" Height="20px"></asp:TextBox>
        <asp:TextBox ID="TextBox2" runat="server" style="margin-left: 102px" Width="200px" Height="20px"></asp:TextBox>
    
        <br />
        <br />
    
    </div>
        <asp:Button ID="Button1" runat="server" Height="38px" style="margin-left: 173px" Text="click on " Width="300px" OnClick="Button1_Click" />
    </form>
</body>
</html>
