<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Index.aspx.cs" Inherits="Index" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <link href="CustomSheet.css" rel="stylesheet" />
</head>
<body>
    <div class="myHeader">
            <header>    
            Employee Management
            </header>
        </div>

    <form id="form1" runat="server" class="myTable">
        

        <asp:Label ID="Label1" runat="server" Text="Ecode" CssClass="myFormLabel"></asp:Label><br />
        <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
        <br />
        <asp:Button ID="Button1" runat="server" Text="Find By Id" Width="80px" />
        <br />
        <br />
        <asp:Label ID="Label2" runat="server" Text="Ename" CssClass="myFormLabel"></asp:Label><br />

        <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
        <br />
        <asp:Label ID="Label3" runat="server" Text="Salary" CssClass="myFormLabel" OnLoad="Label3_Load"></asp:Label>
        <br />
        <asp:TextBox ID="TextBox3" runat="server"></asp:TextBox>
        <br />
        <asp:Label ID="Label4" runat="server" Text="DeptId" CssClass="myFormLabel"></asp:Label>
        
         <br />

        <p>
        <asp:TextBox ID="TextBox4" runat="server"></asp:TextBox>
        </p>
        <p>
        <asp:Button ID="Button2" runat="server" Text="Add" Width="80px" OnClick="Button2_Click" />
             <br />
        <asp:Button ID="Button3" runat="server" Text="Delete" Width="80px" OnClick="Button3_Click" />
             <br />
        <asp:Button ID="Button4" runat="server" Text="Update Salary" Width="80px" />
             <br />
        </p>
        <p>
            <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" CellPadding="4" ForeColor="#333333" GridLines="None" Height="131px" Width="480px">
                <AlternatingRowStyle BackColor="White" />
                <Columns>
                    <asp:BoundField DataField="ecode" HeaderText="ecode" SortExpression="ecode" />
                    <asp:BoundField DataField="ename" HeaderText="ename" SortExpression="ename" />
                    <asp:BoundField DataField="salary" HeaderText="salary" SortExpression="salary" />
                    <asp:BoundField DataField="deptid" HeaderText="deptid" SortExpression="deptid" />
                </Columns>
                <EditRowStyle BackColor="#2461BF" />
                <FooterStyle BackColor="#507CD1" Font-Bold="True" ForeColor="White" />
                <HeaderStyle BackColor="#507CD1" Font-Bold="True" ForeColor="White" />
                <PagerStyle BackColor="#2461BF" ForeColor="White" HorizontalAlign="Center" />
                <RowStyle BackColor="#EFF3FB" />
                <SelectedRowStyle BackColor="#D1DDF1" Font-Bold="True" ForeColor="#333333" />
                <SortedAscendingCellStyle BackColor="#F5F7FB" />
                <SortedAscendingHeaderStyle BackColor="#6D95E1" />
                <SortedDescendingCellStyle BackColor="#E9EBEF" />
                <SortedDescendingHeaderStyle BackColor="#4870BE" />
            </asp:GridView>
        </p>
        <p>
            &nbsp;</p>

    </form>
</body>
</html>
