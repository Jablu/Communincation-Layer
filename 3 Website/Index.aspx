<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Index.aspx.cs" Inherits="Index" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <link href="myStyleSheet.css" rel="stylesheet" />
    <style type="text/css">
        .auto-style1 {
            height: 77px;
        }
    </style>
</head>
<body>
    <div class="myHeader">
            <header>    
            Consuming Web Service
            </header>
        </div>

        <div class="myForm">
        <form id="form2" runat="server" class="myTable">
    

            <table style="width:100%; height: 243px;">
                
                <tr>
                    <td class="auto-style1">
                        <asp:Label ID="lebelEC" runat="server" Text="Enter Value" CssClass="myFormLabel"></asp:Label>
                    </td>
                    <td class="auto-style1">
                        <asp:TextBox ID="vctextboxEC" runat="server" CssClass="myFormInput"></asp:TextBox>
                        <br />
                        <br />
                    </td>
                    
                    
                </tr>
                <tr>
                    <td class="auto-style2">
                        <asp:Label ID="vclebelPW" runat="server" Text="Enter Value" CssClass="myFormLabel"></asp:Label>
                    </td>
                    <td class="auto-style1">
                        <asp:TextBox ID="vctextboxPW" runat="server"  CssClass="myFormInput" TextMode="Password"></asp:TextBox>
                    </td>
                    
                    
                </tr>
                <tr>
                    <td class="auto-style2">
                        <asp:Button ID="Button1" runat="server" Text="GO" OnClick="Button1_Click" CssClass="myGoButton" Height="50px" Width="567px" />
                    </td>
                    <td class="auto-style1">
                        <asp:Label ID="showBox" runat="server" Text="Enter Value" CssClass="myFormLabel"></asp:Label>
                        <br />
                    </td>
                    
                    
                </tr>
                

            </form>
        </div>
</body>
</html>
