<%@ Page Language="C#" AutoEventWireup="true" CodeFile="BookPage.aspx.cs" Inherits="ABook" %>

<!DOCTYPE html>

<%--THE FILE CREATED BY VLADIMIRS RIBAKOVS--%>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta name="viewport" content="width=device-width, initial-scale=1" />
    <link href="../styles/book-css/main.min.css" rel="stylesheet" />
    <title>Book Page</title>
</head>
<body>
    <form id="form1" runat="server">
        <div class="wrap">
            <div class="container">
                <div class="top-nav">
                    <asp:Button ID="btnLogout" runat="server" Text="Logout" class="btn" OnClick="btnLogout_Click" />
                </div>
                <main class="main-book">
                    <div class="btn-group">
                        <asp:Button ID="btnFind" CssClass="btn" runat="server" Text="Find" OnClick="btnFind_Click" />
                        <asp:Button ID="btnAdd" CssClass="btn" runat="server" OnClick="btnAdd_Click" Text="Add" />
                        <asp:Button ID="btnApply" CssClass="btn" runat="server" Text="Apply" OnClick="btnApply_Click" />
                        <asp:Button ID="btnDisplay" CssClass="btn" runat="server" Text="Display" ValidateRequestMode="Enabled" OnClick="Button1_Click" />
                        <asp:Button ID="btnDelete" CssClass="btn" runat="server" OnClick="btnDelete_Click" Text="Delete" />
                        <asp:Button ID="btnEdit" CssClass="btn" runat="server" OnClick="btnEdit_Click" Text="Edit" />
                    </div>
                    <div class="form">
                        <div class="form-input">
                            <div class="error">
                                <asp:Label ID="lblError" runat="server" Text=""></asp:Label>
                            </div>
                            <div class="form-input--fields">
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
                                    <asp:Button ID="btnOK" CssClass="btn" runat="server" Text="OK" OnClick="btnOK_Click" />
                                    <asp:Button ID="btnCancel" CssClass="btn" runat="server" Text="Cancel" OnClick="btnCancel_Click" />
                                </div>
                            </div>

                        </div>
                    </div>
                    <asp:ListBox ID="lstBooks" runat="server" class="book-list"></asp:ListBox>
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
