<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ViewTransactionDetail.aspx.cs" Inherits="ProFootball.View.ViewTransactionDetail" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Transaction Detail</title>
    <link href="Style.css" rel="stylesheet"/>
</head>
<body>
    <form id="form1" runat="server">
        <div class="header">
            <div class="header-left">
                <a href="Home.aspx">
                    <img src="PEFLogo.png" alt="" style="width:100px" />
                </a>
            </div>

            <div class="header-right">
                <div class="navbar">                
                    <asp:Button ID="viewBtn" runat="server" Text="Player List" OnClick="viewBtn_Click" Visible="false"/>
                    <asp:Button ID="marketBtn" runat="server" Text="Market" OnClick="marketBtn_Click" Visible="false"/>
                    <asp:Button ID="trnBtn" runat="server" Text="Transaction" OnClick="trnBtn_Click" Visible="false"/>
                    <asp:Button ID="mngPlayerBtn" runat="server" Text="Manage Player" OnClick="mngPlayerBtn_Click" Visible="false"/>
                    <asp:Button ID="mngUserBtn" runat="server" Text="Manage User" OnClick="mngUserBtn_Click" Visible="false"/>
                    <asp:Button ID="viewAllTrnBtn" runat="server" Text="Transaction" OnClick="viewAllTrnBtn_Click" Visible="false"/>
                </div>

                <div class="navbarGame">
                    <a href="#" class="hyperlink">Hi,<asp:Label ID="namelbl" runat="server" Text="Label"></asp:Label></a>
                        <div class="navbarDropdown">
                            <asp:Button ID="usrProfileBtn" runat="server" Text="Profile" OnClick="usrProfileBtn_Click" Visible="false"/>
                            <asp:Button ID="changePassBtn" runat="server" Text="Password" OnClick="changePassBtn_Click" Visible="false"/>
                            <asp:Button ID="logoutBtn" runat="server" Text="Logout" OnClick="logoutBtn_Click1"/>
                        </div>
                </div>
            </div>
        </div>

        <div class="trnDetContent" style="padding:50px; padding-left:70px">
            <h1>Transaction <%= Request.QueryString["id"]%></h1>

            <table class="trnDetInfo" style="width: 500px">
                <tr>
                    <td style="text-align:left">Date</td>
                    <td style="text-align:left">: <%= trn.Date %></td>
                </tr>

                <tr>
                    <td style="text-align:left">First Name</td>
                    <td style="text-align:left">: <%= trn.User.Firstname %></td>
                </tr>

                <tr>
                    <td style="text-align:left">Last Name</td>
                    <td style="text-align:left">: <%= trn.User.Lastname %></td>
                </tr>

                <tr>
                    <td style="text-align:left">Email</td>
                    <td style="text-align:left">: <%= trn.User.Email %></td>
                </tr>

                <tr>
                    <td style="text-align:left">Date of Birth</td>
                    <td style="text-align:left">: <%= trn.User.DOB %></td>
                </tr>

                <tr>
                    <td style="text-align:left">Total Quantity</td>
                    <td style="text-align:left">: <%= trn.TransactionDetails.Sum(x => x.Quantity) %></td>
                </tr>
            </table>
            <br />

            <table style="width: 1130px" border="1">
                <tr>
                    <th>Name</th>
                    <th>Nationality</th>
                    <th>Club</th>
                    <th>Price</th>
                    <th>Quantity</th>
                    <th>Subtotal</th>
                </tr>

                <%foreach (var trndet in trn.TransactionDetails)
                    {%>
                <tr>
                    <td><%= trndet.Player.Name %></td>
                    <td><%= trndet.Player.Nationality %></td>
                    <td><%= trndet.Player.Club %></td>
                    <td><%= trndet.Player.Price%></td>
                    <td><%= trndet.Quantity%></td>
                    <td><%= trndet.Quantity * trndet.Player.Price %></td>
                </tr>
                <%} %>

                <tr>
                    <td colspan="5"><b>Total</b></td>
                    <td><%= trn.TransactionDetails.Sum(det => det.Quantity * det.Player.Price) %></td>
                </tr>

            </table>
        </div>

        <div class="footer">
            <h5>&copy 2021 Hadinata Games.</h5>
        </div>
    </form>
</body>
</html>
