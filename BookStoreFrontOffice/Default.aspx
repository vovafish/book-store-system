<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="_Default" %>

<!DOCTYPE html>
<%--
    This is server name 
    v00egd00001l.lec-admin.dmu.ac.uk
--%>

<%--@VR--%>
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Get My Books</title>
    <meta name="viewport" content="width=device-width, initial-scale=1" />
    <link href="styles/book-css/main.min.css" rel="stylesheet" />
    <script src="https://use.fontawesome.com/d44781832a.js"></script>
</head>
<body>
    <form id="form1" runat="server">
        <div class="wrap">
            <div class="container">
                <div class="top-nav">
                    <asp:Button ID="btnLogin" runat="server" Text="Login" class="btn" OnClick="btnLogin_Click" />
                </div>
                <header class="header">
                    <div>
                        <img src="images/book-img/logo.jfif" alt="logo" />
                    </div>
                    <div>
                        <h1>Welcome to the Get My Book</h1>
                        <p>Feel free to find your favourite book</p>
                    </div>
                    <div>
                        <div class="wrapper">
                            <div class="icon facebook">
                                <div class="tooltip">Facebook</div>
                                <span><i class="fa fa-facebook" aria-hidden="true"></i></span>
                            </div>
                            <div class="icon twitter">
                                <div class="tooltip">Twitter</div>
                                <span><i class="fa fa-twitter" aria-hidden="true"></i></span>
                            </div>
                            <div class="icon instagram">
                                <div class="tooltip">Instagram</div>
                                <span><i class="fa fa-instagram" aria-hidden="true"></i></span>
                            </div>
                            <div class="icon youtube">
                                <div class="tooltip">Youtube</div>
                                <span><i class="fa fa-youtube-play" aria-hidden="true"></i></span>
                            </div>
                        </div>
                    </div>
                </header>
                <main class="main">
                    <asp:ListBox ID="lstBooks" runat="server" class="book-list"></asp:ListBox>
                    <div class="btn-feature">
                        <asp:Button ID="btnHTL" CssClass="btn" runat="server" Text="Price: High To Low" OnClick="btnHTL_Click" />
                        <asp:Button ID="btnLTH" CssClass="btn" runat="server" Text="Price: Low To High" OnClick="btnLTH_Click" />
                        <asp:Button ID="btnOBA" CssClass="btn" runat="server" Text="Order By Author" OnClick="btnOBA_Click" />
                        <asp:Button ID="btnOBPY" CssClass="btn" runat="server" Text="Order By Publication Year" OnClick="btnOBPY_Click" />
                    </div>
                    <asp:Label ID="lblError" runat="server" Text="Label"></asp:Label>
                </main>
                <div class="footer">
                    <div class="contain">
                        <div class="col">
                            <h1>Company</h1>
                            <ul>
                                <li>About</li>
                                <li>Mission</li>
                                <li>Services</li>
                                <li>Social</li>
                                <li>Get in touch</li>
                            </ul>
                        </div>
                        <div class="col">
                            <h1>Products</h1>
                            <ul>
                                <li>About</li>
                                <li>Mission</li>
                                <li>Services</li>
                                <li>Social</li>
                                <li>Get in touch</li>
                            </ul>
                        </div>
                        <div class="col">
                            <h1>Accounts</h1>
                            <ul>
                                <li>About</li>
                                <li>Mission</li>
                                <li>Services</li>
                                <li>Social</li>
                                <li>Get in touch</li>
                            </ul>
                        </div>
                        <div class="col">
                            <h1>Resources</h1>
                            <ul>
                                <li>Webmail</li>
                                <li>Redeem code</li>
                                <li>WHOIS lookup</li>
                                <li>Site map</li>
                                <li>Web templates</li>
                                <li>Email templates</li>
                            </ul>
                        </div>
                        <div class="col">
                            <h1>Support</h1>
                            <ul>
                                <li>Contact us</li>
                                <li>Web chat</li>
                                <li>Open ticket</li>
                            </ul>
                        </div>
                        <div class="clearfix"></div>
                    </div>
                </div>
            </div>
        </div>
    </form>
</body>
</html>
