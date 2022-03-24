<%@ Page Language="C#" AutoEventWireup="true" CodeFile="BookDelete.aspx.cs" Inherits="Delete" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Delete Book</title>
    <link href="../styles/book-css/main.min.css" rel="stylesheet" />
</head>
<body>
    <form id="form1" runat="server">
        <div class="wrap">
            <div class="container">
                <div class="top-nav">
                    <asp:Button ID="btnLogout" runat="server" Text="Logout" class="btn" OnClick="btnLogout_Click" />
                </div>
                <main class="main-book">
                    <div class="form">
                        <div class="form-input">
                            <div>
                                <p>Are you sure you want to delete this book?</p>
                                <asp:Button ID="btnYes" CssClass="btn" runat="server" Text="Yes" OnClick="btnYes_Click" />
                                <asp:Button ID="btnNo" CssClass="btn" runat="server" Text="No" OnClick="btnNo_Click" />
                            </div>
                            <div class="error">
                                <asp:Label ID="lblError" runat="server" Text=""></asp:Label>
                            </div>
                        </div>
                    </div>
                </main>
                
            </div>
        </div>
    </form>
</body>
</html>
