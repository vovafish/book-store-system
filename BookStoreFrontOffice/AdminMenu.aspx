<%@ Page Language="C#" AutoEventWireup="true" CodeFile="AdminMenu.aspx.cs" Inherits="AdminMenu" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Button ID="btnBooks" runat="server" Text="Books" OnClick="Button1_Click" />
            <asp:Button ID="btnStaff" runat="server" Text="Staff" OnClick="btnStaff_Click" />
            <asp:Button ID="btnDelivery" runat="server" Text="Delivery" OnClick="btnDelivery_Click" />
            <asp:Button ID="btnCustomers" runat="server" Text="Customers" OnClick="btnCustomers_Click" />
            <asp:Button ID="btnOrders" runat="server" Text="Orders" OnClick="btnOrders_Click" />
            <asp:Button ID="btnSupplier" runat="server" Text="Supplier" OnClick="btnSupplier_Click" />
        </div>
    </form>
</body>
</html>
