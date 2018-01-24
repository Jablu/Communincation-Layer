<%@ Page Language="C#" AutoEventWireup="true" CodeFile="HWSHost.aspx.cs" Inherits="HWSHost" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            Consuming Hello World Services From ASP.NET Web Client<br />
            <br />
            <asp:Button ID="Button1" runat="server" Height="42px" OnClick="Button1_Click" Text="GetMsg HTTP" Width="187px" />
            <br />
            <br />
            <asp:Button ID="Button2" runat="server" Height="47px" OnClick="Button2_Click" Text="GetMessage TCP" Width="188px" />
            <br />
            <br />
            <br />
            Show Box:<br />
            <asp:Label ID="Label1" runat="server" Text="Label"></asp:Label>
            <br />
            <br />
            <br />
            <br />
        </div>
    </form>
</body>
</html>
