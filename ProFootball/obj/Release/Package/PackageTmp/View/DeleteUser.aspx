<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="DeleteUser.aspx.cs" Inherits="ProFootball.View.DeleteUser" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Delete User</title>
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

        <div class="UsrFormContent">
            <h1>Delete User</h1>

            <asp:Label ID="Label1" runat="server" Text="Email: "></asp:Label>
            <asp:Label ID="emailTxt" runat="server" Text="Label"></asp:Label>
            <br /><br /> 

            <asp:Label ID="Label2" runat="server" Text="Firstname: "></asp:Label>
            <asp:Label ID="FnameTxt" runat="server" Text="Label"></asp:Label>
            <br /><br />

            <asp:Label ID="Label3" runat="server" Text="Lastname: "></asp:Label>
            <asp:Label ID="LnameTxt" runat="server" Text="Label"></asp:Label>
            <br /><br />

            <asp:Label ID="Label5" runat="server" Text="Date of Birth: "></asp:Label>
            <asp:Label ID="dobTxt" runat="server" Text="Label"></asp:Label>
            <br /><br />

            <p><asp:Label ID="LblMsg" runat="server" Text=""></asp:Label></p>
            <br />

            <asp:Button ID="deleteBtn" runat="server" Text="Delete" OnClick="deleteBtn_Click"/>
        </div>

        <div class="footer">
            <h5>&copy 2021 Hadinata Games.</h5>
        </div>
    </form>
</body>
</html>
