<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ViewTransactionByUser.aspx.cs" Inherits="ProFootball.View.ViewTransactionByUser" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>View Transaction By user</title>
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

        <div class="trnContent" style="padding: 50px; padding-left:70px">
            <h1>Transactions</h1>

            <table style="width: 1130px">
                <tr>
                    <th>TransactionId</th>
                    <th>Email</th>
                    <th>First Name</th>
                    <th>Date</th>
                    <th>Action</th>
                </tr>

                <asp:Repeater ID="Repeater1" runat="server">
                    <ItemTemplate>
                        <tr>
                            <td><%#Eval("TransactionID")%></td>
                            <td><%#Eval("Email")%></td>
                            <td><%#Eval("User.FirstName")%></td>
                            <td><%#Eval("Date")%></td>
                            <td><a href="ViewTransactionDetail.aspx?id=<%#Eval("TransactionID") %>">View Detail</a></td>
                        </tr>
                    </ItemTemplate>
                </asp:Repeater>
            </table>
        </div>

        <div class="footer">
            <h5>&copy 2021 Hadinata Games.</h5>
        </div>
    </form>
</body>
</html>
