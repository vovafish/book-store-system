<%@ Page Language="C#" AutoEventWireup="true" CodeFile="BookPage.aspx.cs" Inherits="ABook" %>

<!DOCTYPE html>

<%--@VR--%>

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
                        <asp:Button ID="btnFind" CssClass="btn btn-page" runat="server" Text="Find" OnClick="btnFind_Click" />
                        <asp:Button ID="btnAdd" CssClass="btn btn-page" runat="server" OnClick="btnAdd_Click" Text="Add" />
                        <asp:Button ID="btnApply" CssClass="btn btn-page" runat="server" Text="Apply" OnClick="btnApply_Click" />
                        <asp:Button ID="btnDisplay" CssClass="btn btn-page" runat="server" Text="Display" ValidateRequestMode="Enabled" OnClick="Button1_Click" />
                        <asp:Button ID="btnDelete" CssClass="btn btn-page" runat="server" OnClick="btnDelete_Click" Text="Delete" />
                        <asp:Button ID="btnEdit" CssClass="btn btn-page" runat="server" OnClick="btnEdit_Click" Text="Edit" />
                    </div>
                    <div class="form">
                        <div class="form-input">
                            <div class="error">
                                <asp:Label ID="lblError" runat="server" Text=""></asp:Label>
                            </div>
                            <div class="form-wrapper">

                                <div class="form-input--fields form-design">
                                    <div>
                                        <div>
                                            <asp:Label ID="Label1" runat="server" Text="BookId"></asp:Label>
                                            <asp:TextBox type="text" ID="txtBookId" runat="server" placeholder="ID is.."></asp:TextBox>
                                        </div>
                                        <div>
                                            <asp:Label ID="lblAuthor" runat="server" Text="Author"></asp:Label>
                                            <asp:TextBox type="text" ID="txtAuthor" runat="server" placeholder="Author is.."></asp:TextBox>
                                        </div>
                                        <div>
                                            <asp:Label ID="Label2" runat="server" Text="Title"></asp:Label>
                                            <asp:TextBox type="text" ID="txtTitle" runat="server" placeholder="Title is.."></asp:TextBox>
                                        </div>
                                        <div>
                                            <asp:Label ID="Label3" runat="server" Text="Edition"></asp:Label>
                                            <asp:TextBox type="text" ID="txtEdition" runat="server" placeholder="Edition is.."></asp:TextBox>
                                        </div>
                                    </div>
                                    <div>
                                        <div>
                                            <asp:Label ID="Label4" runat="server" Text="Price"></asp:Label>
                                            <asp:TextBox type="text" ID="txtPrice" runat="server" placeholder="Price is.."></asp:TextBox>
                                        </div>
                                        <div>
                                            <asp:Label ID="Label5" runat="server" Text="Pub Year"></asp:Label>
                                            <asp:TextBox type="text" ID="txtPubYear" runat="server" placeholder="Publication year is.."></asp:TextBox>
                                        </div>
                                        <div>
                                            <asp:Label ID="Label6" runat="server" Text="Shelf No"></asp:Label>
                                            <asp:TextBox type="text" ID="txtShelfNo" runat="server" placeholder="Shelf number is.."></asp:TextBox>
                                        </div>
                                        <div>
                                            <asp:Label ID="Label7" runat="server" Text="Genre"></asp:Label>
                                            <asp:TextBox type="text" ID="txtGenre" runat="server" placeholder="Genre is.."></asp:TextBox>
                                        </div>
                                    <div>
                                        <asp:Button ID="btnCancel" CssClass="btn btn-cancel" runat="server" Text="Cancel" OnClick="btnCancel_Click" />
                                    </div>
                                    </div>

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
