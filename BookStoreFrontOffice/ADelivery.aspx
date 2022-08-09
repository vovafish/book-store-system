<%@ Page Language="C#" AutoEventWireup="true" CodeFile="ADelivery.aspx.cs" Inherits="ADelivery" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Label ID="lblTrackDelivery" runat="server" Text="TRACK DELIVERY"></asp:Label>
        </div>
        <p>
            <asp:Label ID="lblDeliveryNo" runat="server" Text="Delivery Number"></asp:Label>
            <asp:TextBox ID="txtDelivery_ID" runat="server" Height="18px" style="margin-left: 33px; margin-top: 11px" Width="151px"></asp:TextBox>
        </p>
        <asp:Label ID="lblOrderNo" runat="server" Text="Order Number "></asp:Label>
        <asp:TextBox ID="txtOrderNo" runat="server" style="margin-left: 42px" Width="154px"></asp:TextBox>
        <p>
            &nbsp;</p>
        <p>
            <asp:Button ID="BtnTrack" runat="server" style="margin-right: 45px" Text="Track delivery" Width="117px" />
            <asp:Button ID="bntCancel" runat="server" Height="26px" Text="Cancel" Width="137px" />
        </p>
        <p>
            &nbsp;</p>
    </form>
</body>
</html>
