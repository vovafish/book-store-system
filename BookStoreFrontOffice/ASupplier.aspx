<%@ Page Language="C#" AutoEventWireup="true" CodeFile="ASupplier.aspx.cs" Inherits="ASupplier" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
        </div>
        <asp:TextBox ID="txtName" runat="server" style="z-index: 1; left: 184px; top: 117px; position: absolute"></asp:TextBox>
        <asp:TextBox ID="txtPhoneNumber" runat="server" style="z-index: 1; left: 186px; top: 163px; position: absolute"></asp:TextBox>
        <asp:TextBox ID="txtDescription" runat="server" style="z-index: 1; left: 188px; top: 211px; position: absolute; width: 301px;"></asp:TextBox>
        <asp:TextBox ID="txtCost" runat="server" style="z-index: 1; left: 185px; top: 262px; position: absolute"></asp:TextBox>
        <asp:TextBox ID="txtAddress" runat="server" style="z-index: 1; left: 187px; top: 311px; position: absolute; width: 290px"></asp:TextBox>
        <asp:TextBox ID="txtPostcode" runat="server" style="z-index: 1; left: 189px; top: 356px; position: absolute; width: 125px"></asp:TextBox>
        <asp:Label ID="lblName" runat="server" style="z-index: 1; left: 29px; top: 117px; position: absolute" Text="Name"></asp:Label>
        <asp:Label ID="lblPhoneNumber" runat="server" style="z-index: 1; left: 26px; top: 165px; position: absolute" Text="Phone Number"></asp:Label>
        <asp:Label ID="lblDescription" runat="server" style="z-index: 1; left: 27px; top: 209px; position: absolute" Text="Description"></asp:Label>
        <asp:Label ID="lblCost" runat="server" style="z-index: 1; left: 29px; top: 263px; position: absolute" Text="Cost"></asp:Label>
        <asp:Label ID="lblAddress" runat="server" style="z-index: 1; left: 26px; top: 310px; position: absolute" Text="Address"></asp:Label>
        <asp:Label ID="lblPostcode" runat="server" style="z-index: 1; left: 27px; position: absolute; top: 357px" Text="Postcode"></asp:Label>
        <asp:Button ID="btnOK" runat="server" OnClick="btnOK_Click" style="z-index: 1; left: 223px; top: 468px; position: absolute; width: 69px" Text="OK" />
        <asp:Button ID="btnCancel" runat="server" OnClick="btnCancel_Click" style="z-index: 1; left: 332px; top: 467px; position: absolute" Text="Cancel" />
        <asp:Label ID="lblError" runat="server" style="z-index: 1; left: 36px; top: 583px; position: absolute" Text="[lblError]" Visible="False"></asp:Label>
        <asp:Button ID="btnFind" runat="server" OnClick="btnFind_Click" style="z-index: 1; left: 376px; top: 78px; position: absolute" Text="Find" />
        <asp:TextBox ID="txtSupplierNo" runat="server" style="z-index: 1; left: 186px; top: 79px; position: absolute"></asp:TextBox>
        <asp:Label ID="lblSupplierNo" runat="server" style="z-index: 1; left: 28px; top: 79px; position: absolute; width: 89px" Text="Supplier No"></asp:Label>
    </form>
</body>
</html>
