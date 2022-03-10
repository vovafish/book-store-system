<%@ Page Language="C#" AutoEventWireup="true" CodeFile="StaffTimeTable.aspx.cs" Inherits="StaffManagement_StaffTimeTable" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <h1>Staff Shift Schedule</h1>
    <form id="form1" runat="server">
        <div>
            <asp:GridView ID="tblSchedule" runat="server" AutoGenerateColumns="False" BackColor="White" BorderColor="#CCCCCC" BorderStyle="None" BorderWidth="1px" CellPadding="3" DataKeyNames="StaffID" DataSourceID="SqlDataSource1" OnSelectedIndexChanged="GridView1_SelectedIndexChanged">
                <Columns>
                    <asp:BoundField DataField="StaffID" HeaderText="StaffID" ReadOnly="True" SortExpression="StaffID" />
                    <asp:BoundField DataField="StaffName" HeaderText="StaffName" SortExpression="StaffName" />
                    <asp:BoundField DataField="Shift 1" HeaderText="Shift 1" SortExpression="Shift 1" />
                    <asp:BoundField DataField="Shift 2" HeaderText="Shift 2" SortExpression="Shift 2" />
                    <asp:BoundField DataField="Shift 3" HeaderText="Shift 3" SortExpression="Shift 3" />
                    <asp:BoundField DataField="Shift 4" HeaderText="Shift 4" SortExpression="Shift 4" />
                    <asp:BoundField DataField="Shift 5" HeaderText="Shift 5" SortExpression="Shift 5" />
                </Columns>
                <FooterStyle BackColor="White" ForeColor="#000066" />
                <HeaderStyle BackColor="#006699" Font-Bold="True" ForeColor="White" />
                <PagerStyle BackColor="White" ForeColor="#000066" HorizontalAlign="Left" />
                <RowStyle ForeColor="#000066" />
                <SelectedRowStyle BackColor="#669999" Font-Bold="True" ForeColor="White" />
                <SortedAscendingCellStyle BackColor="#F1F1F1" />
                <SortedAscendingHeaderStyle BackColor="#007DBB" />
                <SortedDescendingCellStyle BackColor="#CAC9C9" />
                <SortedDescendingHeaderStyle BackColor="#00547E" />
            </asp:GridView>
            <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:ConnectionString %>" SelectCommand="SELECT * FROM [tblSchedule]"></asp:SqlDataSource>
        </div>
    </form>
</body>
</html>
