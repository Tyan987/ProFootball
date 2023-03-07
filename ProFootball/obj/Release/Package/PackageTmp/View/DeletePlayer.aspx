<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="DeletePlayer.aspx.cs" Inherits="ProFootball.View.DeletePlayer" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Delete Player</title>
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
            <h1>Delete Player</h1>

            <asp:Image ID="Image1" runat="server" style="border-radius:20px; width:150px; height:200px; margin-left:27%"/>
            <br /><br />

            <asp:Label ID="Label1" runat="server" Text="Name: "></asp:Label>
            <asp:Label ID="nameTxt" runat="server" Text="Label"></asp:Label>
            <br /><br /> 

            <asp:Label ID="Label3" runat="server" Text="Nationality: "></asp:Label>
            <asp:Label ID="nationalityTxt" runat="server" Text="Label"></asp:Label>
            <br /><br />

            <asp:Label ID="Label4" runat="server" Text="Club: "></asp:Label>
            <asp:Label ID="clubTxt" runat="server" Text="Label"></asp:Label>
            <br /><br />

            <asp:Label ID="Label5" runat="server" Text="Age: "></asp:Label>
            <asp:Label ID="ageTxt" runat="server" Text="Label"></asp:Label>
            <br /><br />

            <asp:Label ID="Label6" runat="server" Text="Price: "></asp:Label>
            <asp:Label ID="priceTxt" runat="server" Text="Label"></asp:Label>
            <br /><br />

            <asp:Label ID="Label7" runat="server" Text="Player Position: "></asp:Label>
            <asp:Label ID="positionTxt" runat="server" Text="Label"></asp:Label>
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
