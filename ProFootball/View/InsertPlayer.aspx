<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="InsertPlayer.aspx.cs" Inherits="ProFootball.View.InsertPlayer" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Insert Player</title>
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
            <h1>Insert Player</h1>

            <asp:TextBox ID="nameTxt" runat="server" placeHolder="Name" style="width:97%"></asp:TextBox>
            <br /><br /> 

            <asp:FileUpload ID="FileUploadImage" runat="server" style="width:65%"/>
            <br /><br />

            <asp:TextBox ID="nationalityTxt" runat="server" placeHolder="Nationality" style="width:97%"></asp:TextBox>
            <br /><br />

            <asp:TextBox ID="clubTxt" runat="server" placeHolder="Club" style="width:97%"></asp:TextBox>
            <br /><br />

            <asp:TextBox ID="ageTxt" runat="server" placeHolder="Age" style="width:97%"></asp:TextBox>
            <br /><br />

            <asp:TextBox ID="priceTxt" runat="server" placeHolder="Price" style="width:97%"></asp:TextBox>
            <br /><br />

            <asp:TextBox ID="positionTxt" runat="server" placeHolder="Position ID" style="width:97%"></asp:TextBox>
            <br /><br />

            <p><asp:Label ID="LblMsg" runat="server" Text=""></asp:Label></p>
            <br />

            <asp:Button ID="insertBtn" runat="server" Text="Insert" OnClick="insertBtn_Click"/>
        </div>

        <div class="footer">
            <h5>&copy 2021 Hadinata Games.</h5>
        </div>
    </form>
</body>
</html>
