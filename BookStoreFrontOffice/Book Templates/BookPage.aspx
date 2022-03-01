<%@ Page Language="C#" AutoEventWireup="true" CodeFile="BookPage.aspx.cs" Inherits="ABook" %>

<!DOCTYPE html>

<%--THE FILE CREATED BY VLADIMIRS RIBAKOVS--%>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <link href="css/style.css" rel="stylesheet" />
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
            <asp:Button ID="btnFind" runat="server" Text="Find" OnClick="btnFind_Click" />
            <asp:Button ID="btnAdd" runat="server" OnClick="btnAdd_Click" Text="Add" />
            <asp:Button ID="btnApply" runat="server" Text="Apply" OnClick="btnApply_Click" style="height: 29px" />
            <asp:Button ID="btnDisplay" runat="server" Text="Display" ValidateRequestMode="Enabled" OnClick="Button1_Click" />
            <asp:Button ID="btnDelete" runat="server" OnClick="btnDelete_Click" Text="Delete" />
            <asp:Button ID="btnEdit" runat="server" OnClick="btnEdit_Click" Text="Edit" />
        <div>
            <asp:Label ID="Label1" runat="server" Text="BookId"></asp:Label>
            <asp:TextBox ID="txtBookId" runat="server"></asp:TextBox>
        </div>
        <div>
            <asp:Label ID="lblAuthor" runat="server" Text="Author"></asp:Label>
            <asp:TextBox ID="txtAuthor" runat="server"></asp:TextBox>
        </div>
        <div>
            <asp:Label ID="Label2" runat="server" Text="Title"></asp:Label>
            <asp:TextBox ID="txtTitle" runat="server"></asp:TextBox>
        </div>
        <div>
            <asp:Label ID="Label3" runat="server" Text="Edition"></asp:Label>
            <asp:TextBox ID="txtEdition" runat="server"></asp:TextBox>
        </div>
        <div>
            <asp:Label ID="Label4" runat="server" Text="Price"></asp:Label>
            <asp:TextBox ID="txtPrice" runat="server"></asp:TextBox>
        </div>
        <div>
            <asp:Label ID="Label5" runat="server" Text="Pub Year"></asp:Label>
            <asp:TextBox ID="txtPubYear" runat="server"></asp:TextBox>
        </div>
        <div>
            <asp:Label ID="Label6" runat="server" Text="Shelf No"></asp:Label>
            <asp:TextBox ID="txtShelfNo" runat="server"></asp:TextBox>
        </div>
        <div>
            <asp:Label ID="Label7" runat="server" Text="Genre"></asp:Label>
            <asp:TextBox ID="txtGenre" runat="server"></asp:TextBox>
        </div>
        <div>
            <asp:Label ID="lblError" runat="server" Text=""></asp:Label>
        </div>
        <div>
            <asp:Button ID="btnOK" runat="server" Text="OK" OnClick="btnOK_Click" />
            <asp:Button ID="btnCancel" runat="server" Text="Cancel" />
        </div>
            <asp:ListBox ID="lstBooks" runat="server" Height="111px" Width="158px"></asp:ListBox>
    </form>
</body>
</html>
