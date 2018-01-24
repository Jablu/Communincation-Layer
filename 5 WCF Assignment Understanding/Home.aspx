<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Home.aspx.cs" Inherits="Home" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <link href="CustomSheet.css" rel="stylesheet" />
</head>
<body>

    <div class="myHeader">
            <header>    
            Customer Consume From Web Service
            </header>
        </div>

        <div class="myForm">
        <form id="form1" runat="server" class="myTable">
    
    
            <table style="width:100%; height: 243px;">
                
                <tr>
                    <td class="auto-style2">
                        <asp:Label ID="Label1" runat="server" Text="Enter Amount: " CssClass="myFormLabel"></asp:Label>
                    </td>
                    <td class="auto-style1">
                        <asp:TextBox ID="textCode" runat="server" CssClass="myFormInput"></asp:TextBox>
                    </td>
                   
                </tr>
                
                <tr>
                    <td class="auto-style2">
                        <asp:Label ID="Label3" runat="server" Text="Customer Id" CssClass="myFormLabel"></asp:Label>
                    </td>
                    <td class="auto-style1">
                        <asp:TextBox ID="textSalary" runat="server" CssClass="myFormInput"></asp:TextBox>
                    </td>
                    
                </tr>
                <tr>
                    
                    <td class="auto-style1">
                        <asp:Button ID="btnIns" runat="server" Text="Deposit" CssClass="myGoButton" Height="33px" Width="117px" OnClick="btnIns_Click"  />
                        <asp:Button ID="btnDel" runat="server" Text="Withdraw" CssClass="myGoButton" Height="33px" Width="117px" OnClick="btnDel_Click"  />
                        <asp:Button ID="btnShow" runat="server" Text="Check Balance" CssClass="myGoButton" Height="33px" Width="117px" OnClick="btnShow_Click"  />
                    </td>
                    <td>
                        
                        <asp:Label ID="Label4" runat="server" Text="showBox" CssClass="myFormLabel"></asp:Label>
                        
                    </td>
                </tr>
               
               
                </table>
    
        
        </form>
        </div>

    </body>
</html>
