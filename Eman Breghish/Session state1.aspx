<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Session state1.aspx.cs" Inherits="Eman_Breghish.Session_state1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <asp:TextBox ID="TextBox1" runat="server" OnTextChanged="TextBox1_TextChanged"></asp:TextBox>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <p>
            <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Session state" />
        </p>
    </form>
</body>
</html>
