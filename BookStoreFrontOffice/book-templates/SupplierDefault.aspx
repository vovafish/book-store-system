<%@ Page Language="C#" AutoEventWireup="true" CodeFile="SupplierDefault.aspx.cs" Inherits="SupplierDefault" %>


<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Supplier</title>
    <style type="text/css">
        .auto-style1 {
            z-index: 1;
            left: 334px;
            top: 397px;
            position: absolute;
            height: 58px;
            width: 339px;
            margin-top: 3px;
        }
        #Text1 {
            z-index: 1;
            left: 0px;
            top: 0px;
            position: absolute;
        }
        .auto-style6 {
            z-index: 1;
            left: 411px;
            top: 537px;
            position: absolute;
            height: 33px;
            width: 318px;
        }
        .auto-style12 {
            z-index: 1;
            left: 755px;
            top: 533px;
            position: absolute;
            height: 47px;
            width: 118px;
        }
        .auto-style13 {
            z-index: 1;
            left: 88px;
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
            left: 86px;
            top: 610px;
            position: absolute;
            height: 73px;
            width: 185px;
        }
        .auto-style16 {
            z-index: 1;
            left: 643px;
            top: 498px;
            position: absolute;
        }
        .auto-style17 {
            z-index: 1;
            left: 412px;
            top: 606px;
            position: absolute;
            height: 397px;
            width: 458px;
        }
        .auto-style18 {
            z-index: 1;
            left: 888px;
            top: 605px;
            position: absolute;
            height: 46px;
            width: 144px;
        }
        .auto-style19 {
            z-index: 1;
            left: 340px;
            top: 460px;
            position: absolute;
        }
    </style>
</head>
<body style="font-family: Arial, Helvetica, sans-serif; color: #33CCFF; background-color: #666666">
    <form id="form3" runat="server">
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
            <asp:Button ID="BtnSignUp" runat="server" style="z-index: 1; left: 1499px; top: 100px; position: absolute; height: 44px; width: 110px; font-weight: 700" Text="Sign Up" BackColor="#333333" ForeColor="#33CCFF" OnClick="BtnSignUp_Click" />
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
        <asp:Button ID="BtnHome" runat="server" BackColor="#333333" ForeColor="#00CCFF" style="z-index: 1; left: 447px; top: 304px; position: absolute; height: 51px; width: 149px; font-weight: 700; margin-right: 0px;" Text="Home" OnClick="BtnHome_Click" />
            <asp:Label ID="LblInstruction" runat="server" CssClass="auto-style19" Text="Please select the book supplier in the list and then click select supplier to view it's profile:"></asp:Label>
        </p>
        <asp:Button ID="BtnStaff" runat="server" style="z-index: 1; left: 1444px; top: 162px; position: absolute; height: 49px; width: 87px; font-weight: 700" Text="Staff" BackColor="#333333" ForeColor="#33CCFF" OnClick="BtnStaff_Click" />
        <p>
            <asp:Label ID="LblSearchSupplier" runat="server" CssClass="auto-style1" Font-Bold="True" Font-Size="X-Large" Text="Search for a supplier:"></asp:Label>
            <asp:Button ID="BtnAddSupplierPage" OnClick="BtnAddSupplierPage_Click" runat="server" BackColor="#333333" CssClass="auto-style13" Font-Bold="True" ForeColor="#33CCFF" Text="Add a New Suppiler" />
        </p>
        <asp:Button ID="BtnSupplier" runat="server" style="z-index: 1; left: 750px; top: 304px; position: absolute; height: 50px; width: 151px; font-weight: 700; right: 1249px;" Text="Suppliers" BackColor="#333333" ForeColor="#33CCFF" OnClick="BtnSupplier_Click" />
        <asp:Button ID="BtnUsers" runat="server" style="z-index: 1; left: 902px; top: 304px; position: absolute; height: 50px; width: 150px; font-weight: 700; right: 1310px;" Text="Users" BackColor="#333333" ForeColor="#33CCFF" OnClick="BtnUsers_Click" />
        <asp:Button ID="BtnLogin" runat="server" OnClick="Button2_Click" style="z-index: 1; left: 1372px; top: 100px; position: absolute; height: 48px; width: 99px; font-weight: 700; right: 891px;" Text="Login" BackColor="#333333" ForeColor="#33CCFF" />
        <p>
            <asp:Button ID="BtnSelectSupplier" OnClick="BtnSelectSupplier_Click" runat="server" BackColor="#333333" CssClass="auto-style18" Font-Bold="True" ForeColor="#33CCFF" Text="Select Supplier" />
        </p>
        <asp:Button ID="BtnOrders" runat="server" style="z-index: 1; top: 303px; position: absolute; left: 1055px; height: 50px; width: 151px; font-weight: 700" Text="Orders" BackColor="#333333" ForeColor="#33CCFF" OnClick="BtnOrders_Click" />
        <asp:Button ID="BtnBooks" runat="server" style="z-index: 1; left: 599px; top: 303px; position: absolute; height: 51px; width: 150px; font-weight: 700; right: 1609px; margin-right: 4px;" Text="Books" BackColor="#333333" ForeColor="#33CCFF" OnClick="BtnBooks_Click" />
        <p>
            <asp:Button ID="BtnEditASupplierPage" OnClick="BtnEditSupplierPage_Click" runat="server" BackColor="#333333" CssClass="auto-style14" Font-Bold="True" ForeColor="#33CCFF" Text="Edit a Supplier" />
            <asp:DropDownList ID="DdlSupplier" runat="server" CssClass="auto-style16" BackColor="#333333" ForeColor="#33CCFF" OnSelectedIndexChanged="DdlSupplier_SelectedIndexChanged">
                <asp:ListItem>Alphabetical: Acending</asp:ListItem>
                <asp:ListItem>Alphabetical: Decending</asp:ListItem>
                <asp:ListItem>Featured</asp:ListItem>
                <asp:ListItem>Most Used</asp:ListItem>
                <asp:ListItem></asp:ListItem>
            </asp:DropDownList>
        </p>
        <p>
            &nbsp;</p>
    <p style="text-align: left">
        <asp:Button ID="BtnDeleteASupplier" OnClick="BtnDeleteSupplierPage_Click" runat="server" BackColor="#333333" CssClass="auto-style15" Font-Bold="True" ForeColor="#33CCFF" Text="Delete a Supplier" />
        </p>
        <p style="text-align: left">
            &nbsp;</p>
        <p>
            <asp:TextBox ID="TxtSearchSupplier" runat="server" BackColor="#333333" CssClass="auto-style6" ForeColor="#33CCFF" OnTextChanged="TxtSearchSupplier_TextChanged"></asp:TextBox>
        </p>
        <asp:Button ID="BtnSearchSupplier" OnClick="BtnSearch_Click" runat="server" BackColor="#333333" CssClass="auto-style12" Font-Bold="True" ForeColor="#33CCFF" Text="Search" />
        <asp:ListBox ID="LstSupplier" runat="server" BackColor="#333333" CssClass="auto-style17" ForeColor="#33CCFF" Font-Bold="False" Font-Names="Calibri" Font-Size="Large" Font-Underline="True" OnSelectedIndexChanged="LstSupplier_SelectedIndexChanged"></asp:ListBox>
    </form>
</body>
</html>