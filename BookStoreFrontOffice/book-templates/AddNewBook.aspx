<%@ Page Language="C#" AutoEventWireup="true" CodeFile="AddNewBook.aspx.cs" Inherits="AddNewBook" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>New Book</title>
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
                            </div>
                            <div>
                                <asp:Button ID="btnOK" runat="server" Text="OK" OnClick="btnOK_Click" />
                                <asp:Button ID="btnCancel" runat="server" Text="Cancel" OnClick="btnCancel_Click" />
                            </div>
                            <div class="error">
                                <asp:Label ID="lblError" runat="server" Text=""></asp:Label>
                            </div>
                        </div>
                    </div>
                </main>
                <footer class="footer">
                    <nav>
                        <div class="copy">
                            <p></p>
                        </div>
                        <div class="links">
                            <a href="#">Careers</a>
                            <a href="#">About Us</a>
                        </div>
                    </nav>
                </footer>
            </div>
        </div>
    </form>
</body>
</html>
