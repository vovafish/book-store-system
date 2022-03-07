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
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <div class="wrap">
               <div class="container">
                   
                   <div class="top-nav">
                        <asp:Button ID="btnLogin" runat="server" Text="Login" class="btn"/>
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
                        <a>Link1</a>
                        <a>Lik2</a>
                    </div>
                </header>
                <main class="main">
                    <asp:ListBox ID="ListBox1" runat="server"></asp:ListBox>
                    <asp:DropDownList ID="DropDownList1" runat="server">
                      <asp:ListItem Selected="True" Value="Featured"> Featured </asp:ListItem>
                      <asp:ListItem Value="PriceLowToHigh"> Price: Low To High </asp:ListItem>
                      <asp:ListItem Value="PriceHighToLow"> Price: High To Low </asp:ListItem>
                      <asp:ListItem Value="Newest Arrivals"> Newest Arrivals </asp:ListItem>
                    </asp:DropDownList>
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
        </div>
    </form>
</body>
</html>
