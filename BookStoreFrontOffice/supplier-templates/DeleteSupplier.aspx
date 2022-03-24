<%@ Page Language="C#" AutoEventWireup="true" CodeFile="DeleteSupplier.aspx.cs" Inherits="DeleteSupplier" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Delete Supplier</title>
    <style type="text/css">
        .auto-style1 {
            z-index: 1;
            left: 452px;
            top: 470px;
            position: absolute;
            height: 43px;
            width: 339px;
            margin-top: 3px;
        }
        #Text1 {
            z-index: 1;
            left: 0px;
            top: 0px;
            position: absolute;
        }
        .auto-style12 {
            z-index: 1;
            left: 450px;
            top: 579px;
            position: absolute;
            height: 47px;
            width: 149px;
            right: 762px;
        }
        .auto-style13 {
            z-index: 1;
            left: 87px;
            top: 474px;
            position: absolute;
            width: 185px;
            height: 75px;
            margin-bottom: 0px;
        }
        .auto-style14 {
            z-index: 1;
            left: 87px;
            top: 548px;
            position: absolute;
            width: 185px;
            height: 61px;
        }
        .auto-style15 {
            z-index: 1;
            left: 87px;
            top: 610px;
            position: absolute;
            height: 73px;
            width: 185px;
        }
    </style>
</head>
<body style="font-family: Arial, Helvetica, sans-serif; color: #33CCFF; background-color: #666666">
    <form id="form2" runat="server">
        <p>
            &nbsp;</p>
        <p style="height: 0px">
            &nbsp;</p>
        <p>
            &nbsp;</p>
        <p>
            &nbsp;</p>
        <asp:Image ID="ImgProfileIcon" runat="server" style="z-index: 1; left: 1277px; top: 100px; position: absolute; height: 51px; width: 54px; right: 1031px;" BackColor="#333333" ImageUrl="/images/Supplier-img/ImgIcon.jpg" />
        <p>
            <asp:Button ID="BtnSignUp" runat="server" style="z-index: 1; left: 1499px; top: 100px; position: absolute; height: 44px; width: 110px; font-weight: 700" Text="Sign Up" BackColor="#333333" ForeColor="#33CCFF" />
        </p>
        <p>
            &nbsp;</p>
        <p>
            &nbsp;</p>
        <p style="height: 43px">
            <asp:Image ID="ImgLogo" runat="server" style="z-index: 1; left: 80px; top: 99px; position: absolute; height: 243px; text-align: center;" ImageUrl="/images/Supplier-img/getmybooks%20logo.jpg" />
        </p>
        <p>
            <asp:Image ID="ImgWelcome" runat="server" style="z-index: 1; left: 480px; top: 99px; position: absolute; width: 705px; height: 127px; margin-top: 0px; text-align: center;" ImageUrl="/images/Supplier-img/ImgHeader.jpg" />
        <asp:Button ID="BtnHome" runat="server" BackColor="#333333" ForeColor="#00CCFF" style="z-index: 1; left: 447px; top: 302px; position: absolute; height: 53px; width: 149px; font-weight: 700; margin-right: 0px;" Text="Home" OnClick="BtnHome_Click" />
        </p>
        <asp:Button ID="BtnStaff" runat="server" style="z-index: 1; left: 1444px; top: 162px; position: absolute; height: 49px; width: 87px; font-weight: 700" Text="Staff" BackColor="#333333" ForeColor="#33CCFF" />
        <p>
            <asp:Label ID="LblDeleteSupplier" runat="server" CssClass="auto-style1" Font-Bold="True" Font-Size="X-Large" Text="Delete a supplier:"></asp:Label>
            <asp:Button ID="BtnAddSupplierPage" OnClick="BtnAddSupplierPage_Click" runat="server" BackColor="#333333" CssClass="auto-style13" Font-Bold="True" ForeColor="#33CCFF" Text="Add a New Suppiler" />
        </p>
        <asp:Button ID="BtnSupplier" OnClick="BtnSupplier_Click" runat="server" style="z-index: 1; left: 750px; top: 300px; position: absolute; height: 54px; width: 150px; font-weight: 700; right: 1462px;" Text="Suppliers" BackColor="#333333" ForeColor="#33CCFF" />
        <asp:Button ID="BtnUsers" runat="server" style="z-index: 1; left: 902px; top: 303px; position: absolute; height: 50px; width: 150px; font-weight: 700; right: 1310px;" Text="Users" BackColor="#333333" ForeColor="#33CCFF" />
        <asp:Button ID="BtnLogin" runat="server" style="z-index: 1; left: 1372px; top: 100px; position: absolute; height: 48px; width: 99px; font-weight: 700; right: 891px;" Text="Login" BackColor="#333333" ForeColor="#33CCFF" />
        <p>
            &nbsp;</p>
        <asp:Button ID="BtnOrders" runat="server" style="z-index: 1; top: 301px; position: absolute; left: 1054px; height: 52px; width: 151px; font-weight: 700" Text="Orders" BackColor="#333333" ForeColor="#33CCFF" />
        <asp:Button ID="BtnBooks" runat="server" style="z-index: 1; left: 599px; top: 302px; position: absolute; height: 51px; width: 150px; font-weight: 700; right: 1609px; margin-right: 4px;" Text="Books" BackColor="#333333" ForeColor="#33CCFF" />
        <asp:Label ID="Label1" runat="server" style="z-index: 1; left: 448px; top: 540px; position: absolute; width: 317px" Text="Are you sure you want to delete this supplier?"></asp:Label>
        <p>
            <asp:Button ID="BtnEditASupplierPage" OnClick="BtnEditSupplierPage_Click" runat="server" BackColor="#333333" CssClass="auto-style14" Font-Bold="True" ForeColor="#33CCFF" Text="Edit a Supplier" />
        </p>
        <p>
            &nbsp;</p>
    <p style="text-align: left">
        <asp:Button ID="BtnDeleteASupplier" OnClick="BtnDeleteSupplierPage_Click" runat="server" BackColor="#333333" CssClass="auto-style15" Font-Bold="True" ForeColor="#33CCFF" Text="Delete a Supplier" />
        </p>
        <p style="text-align: left">
            &nbsp;</p>
        <p>
         
            <asp:Button ID="btnCancel" runat="server" BackColor="#333333" CssClass="auto-style12" Font-Bold="True" ForeColor="#33CCFF" OnClick="btnCancel_Click" style="z-index: 1; left: 603px; top: 579px; position: absolute; height: 47px; width: 120px" Text="No, cancel" />
        </p>
        <asp:Button ID="btnYesDelete" OnClick="btnYesDelete_Click"  runat="server" BackColor="#333333" CssClass="auto-style12" Font-Bold="True" ForeColor="#33CCFF" Text="Yes! Delete Supplier" />
    </form>
</body>
</html>
