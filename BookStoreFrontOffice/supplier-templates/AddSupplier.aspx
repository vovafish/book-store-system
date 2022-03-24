<%@ Page Language="C#" AutoEventWireup="true" CodeFile="AddSupplier.aspx.cs" Inherits="AddSupplier" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Add New Supplier</title>
    <style type="text/css">
        .auto-style1 {
            z-index: 1;
            left: 452px;
            top: 470px;
            position: absolute;
            height: 34px;
            width: 339px;
            margin-top: 3px;
        }
        #Text1 {
            z-index: 1;
            left: 0px;
            top: 0px;
            position: absolute;
        }
        .auto-style2 {
            z-index: 1;
            left: 445px;
            top: 549px;
            position: absolute;
            width: 274px;
            margin-top: 0px;
            margin-bottom: 0px;
        }
        .auto-style3 {
            z-index: 1;
            left: 444px;
            top: 589px;
            position: absolute;
            height: 89px;
            width: 312px;
        }
        .auto-style4 {
            z-index: 1;
            left: 445px;
            top: 700px;
            position: absolute;
            width: 131px;
        }
        .auto-style5 {
            z-index: 1;
            left: 1017px;
            top: 597px;
            position: absolute;
            height: 148px;
            width: 301px;
        }
        .auto-style6 {
            z-index: 1;
            left: 1019px;
            top: 551px;
            position: absolute;
            height: 22px;
        }
        .auto-style7 {
            z-index: 1;
            left: 302px;
            top: 547px;
            position: absolute;
        }
        .auto-style8 {
            z-index: 1;
            left: 350px;
            top: 592px;
            position: absolute;
        }
        .auto-style9 {
            z-index: 1;
            left: 342px;
            top: 642px;
            position: absolute;
            height: 23px;
            margin-top: 59px;
        }
        .auto-style10 {
            z-index: 1;
            left: 917px;
            top: 556px;
            position: absolute;
            bottom: 836px;
        }
        .auto-style11 {
            z-index: 1;
            left: 908px;
            top: 598px;
            position: absolute;
        }
        .auto-style12 {
            z-index: 1;
            left: 1208px;
            top: 770px;
            position: absolute;
            height: 47px;
            width: 118px;
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
            left: 86px;
            top: 610px;
            position: absolute;
            height: 73px;
            width: 185px;
        }
        .auto-style16 {
            z-index: 1;
            left: 360px;
            top: 802px;
            position: absolute;
            height: 29px;
            width: 465px;
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
            <asp:Label ID="LblAddNewSupplier" runat="server" CssClass="auto-style1" Font-Bold="True" Font-Size="X-Large" Text="Add a new supplier:"></asp:Label>
            <asp:Button ID="BtnAddSupplierPage" OnClick="BtnAddSupplierPage_Click" runat="server" BackColor="#333333" CssClass="auto-style13" Font-Bold="True" ForeColor="#33CCFF" Text="Add a New Suppiler" />
        </p>
        <asp:Button ID="BtnSupplier" OnClick="BtnSupplier_Click" runat="server" style="z-index: 1; left: 750px; top: 300px; position: absolute; height: 54px; width: 150px; font-weight: 700; right: 1462px;" Text="Suppliers" BackColor="#333333" ForeColor="#33CCFF" />
        <asp:Button ID="BtnUsers" runat="server" style="z-index: 1; left: 902px; top: 303px; position: absolute; height: 50px; width: 150px; font-weight: 700; right: 1310px;" Text="Users" BackColor="#333333" ForeColor="#33CCFF" />
        <asp:Button ID="BtnLogin" runat="server" style="z-index: 1; left: 1372px; top: 100px; position: absolute; height: 48px; width: 99px; font-weight: 700; right: 891px;" Text="Login" BackColor="#333333" ForeColor="#33CCFF" />
            <asp:TextBox ID="txtPhoneNumber" runat="server" BackColor="#333333" CssClass="auto-style6" ForeColor="#33CCFF" OnTextChanged="txtPhoneNumber_TextChanged"></asp:TextBox>
        <p>
            <asp:Label ID="lblCost" runat="server" style="z-index: 1; left: 947px; top: 511px; position: absolute; width: 40px" Text="Cost: "></asp:Label>
        </p>
        <asp:Button ID="BtnOrders" runat="server" style="z-index: 1; top: 301px; position: absolute; left: 1054px; height: 52px; width: 151px; font-weight: 700" Text="Orders" BackColor="#333333" ForeColor="#33CCFF" />
        <asp:Button ID="BtnBooks" runat="server" style="z-index: 1; left: 599px; top: 302px; position: absolute; height: 51px; width: 150px; font-weight: 700; right: 1609px; margin-right: 4px;" Text="Books" BackColor="#333333" ForeColor="#33CCFF" />
        <asp:TextBox ID="txtCost" runat="server" BackColor="#333333" ForeColor="#33CCFF" style="z-index: 1; left: 1014px; top: 507px; position: absolute; height: 20px" OnTextChanged="txtCost_TextChanged"></asp:TextBox>
        <p>
            <asp:TextBox ID="txtPostcode" runat="server" BackColor="#333333" CssClass="auto-style4" ForeColor="#33CCFF"></asp:TextBox>
            <asp:TextBox ID="txtAddress" runat="server" BackColor="#333333" CssClass="auto-style3" ForeColor="#33CCFF"></asp:TextBox>
            <asp:Button ID="BtnEditASupplierPage" OnClick="BtnEditSupplierPage_Click" runat="server" BackColor="#333333" CssClass="auto-style14" Font-Bold="True" ForeColor="#33CCFF" Text="Edit a Supplier" />
        </p>
        <p>
            <asp:TextBox ID="txtDescription" runat="server" BackColor="#333333" CssClass="auto-style5" ForeColor="#33CCFF"></asp:TextBox>
        </p>
    <p style="text-align: left">
        <asp:Label ID="LblPostcode" runat="server" CssClass="auto-style9" Text="Postcode:"></asp:Label>
        <asp:Label ID="LblPhone" runat="server" CssClass="auto-style10" Text="Phone No:"></asp:Label>
        <asp:Label ID="LblDescription" runat="server" CssClass="auto-style11" Text="Description:"></asp:Label>
        <asp:Button ID="BtnDeleteASupplier" OnClick="BtnDeleteSupplierPage_Click" runat="server" BackColor="#333333" CssClass="auto-style15" Font-Bold="True" ForeColor="#33CCFF" Text="Delete a Supplier" />
        </p>
        <p style="text-align: left">
            &nbsp;</p>
        <asp:TextBox ID="txtName" runat="server" CssClass="auto-style2" BackColor="#333333" ForeColor="#33CCFF"></asp:TextBox>
        <p>
            &nbsp;</p>
        <asp:Label ID="LblName" runat="server" CssClass="auto-style7" Text="Supplier Name:"></asp:Label>
        <asp:Label ID="LblAddress" runat="server" CssClass="auto-style8" Text="Address:"></asp:Label>
        <asp:Button ID="BtnAddSupplier" OnClick="BtnAddSupplier_Click" runat="server" BackColor="#333333" CssClass="auto-style12" Font-Bold="True" ForeColor="#33CCFF" Text="Add Supplier" />
        <asp:Label ID="lblError" runat="server" CssClass="auto-style16" Text="Success! The Supplier has been successfully added." Visible="False"></asp:Label>
    </form>
</body>
</html>
