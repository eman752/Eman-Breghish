<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Cookie state 1.aspx.cs" Inherits="Eman_Breghish.Cookie_state_1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <asp:Label ID="Label1" runat="server" Text="This is Cookie state 1 :"></asp:Label>
        <br />
        <asp:Label ID="Label2" runat="server" Text="Name :"></asp:Label>
&nbsp;
        <asp:TextBox ID="txtname" runat="server"></asp:TextBox>
        <br />
        <asp:Label ID="Label3" runat="server" Text="Email :"></asp:Label>
&nbsp;
        <asp:TextBox ID="txtEmail" runat="server"></asp:TextBox>
        <br />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Button ID="Button1" runat="server" Text="Go to Cookie state 2" OnClick="Button1_Click" />
    </form>
</body>
</html>
