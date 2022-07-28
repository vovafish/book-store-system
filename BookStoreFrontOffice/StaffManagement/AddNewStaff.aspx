<%@ Page Language="C#" AutoEventWireup="true" CodeFile="AddNewStaff.aspx.cs" Inherits="StaffManagement_AddNewStaff" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            Add New Staff<br />
        </div>
        <asp:Label ID="lblFistName" runat="server" style="z-index: 1; left: 10px; top: 53px; position: absolute" Text="FirstName"></asp:Label>
        <asp:TextBox ID="txtFristName" runat="server" style="z-index: 1; left: 81px; top: 54px; position: absolute"></asp:TextBox>
        <asp:Label ID="lblLastName" runat="server" style="z-index: 1; left: 10px; top: 95px; position: absolute" Text="LastName"></asp:Label>
        <asp:TextBox ID="txtLastName" runat="server" style="z-index: 1; left: 81px; top: 93px; position: absolute; margin-bottom: 0px"></asp:TextBox>
        <asp:TextBox ID="txtDoB" runat="server" style="z-index: 1; left: 81px; top: 130px; position: absolute"></asp:TextBox>
        <asp:TextBox ID="txtAddress" runat="server" style="z-index: 1; left: 81px; top: 160px; position: absolute"></asp:TextBox>
        <asp:Label ID="lblDoB" runat="server" style="z-index: 1; left: 10px; top: 132px; position: absolute" Text="D.o.B"></asp:Label>
        <asp:Label ID="lblAddress" runat="server" style="z-index: 1; left: 10px; top: 162px; position: absolute" Text="Address"></asp:Label>
        <asp:Label ID="lblRole" runat="server" style="z-index: 1; left: 229px; top: 55px; position: absolute" Text="Role"></asp:Label>
        <asp:Label ID="lblNo" runat="server" style="z-index: 1; left: 231px; top: 94px; position: absolute" Text="Contact No."></asp:Label>
        <asp:Label ID="lblEmail" runat="server" style="z-index: 1; left: 233px; top: 132px; position: absolute" Text="Email"></asp:Label>
        <asp:Label ID="lblLeave" runat="server" style="z-index: 1; left: 231px; top: 160px; position: absolute" Text="Annual Leave"></asp:Label>
        <asp:TextBox ID="txtRole" runat="server" style="z-index: 1; left: 320px; top: 54px; position: absolute"></asp:TextBox>
        <asp:TextBox ID="txtNo" runat="server" style="z-index: 1; left: 319px; top: 93px; position: absolute"></asp:TextBox>
        <asp:TextBox ID="txtEmail" runat="server" style="z-index: 1; left: 319px; top: 132px; position: absolute"></asp:TextBox>
        <asp:TextBox ID="txtLeave" runat="server" style="z-index: 1; left: 319px; top: 160px; position: absolute"></asp:TextBox>
        <asp:Button ID="btnAdd" runat="server" style="z-index: 1; left: 459px; top: 161px; position: absolute" Text="Add Staff" OnClick="btnAdd_Click" />
    </form>
</body>
</html>
