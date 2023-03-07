<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ManagePlayer.aspx.cs" Inherits="ProFootball.View.ManagePlayer" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Manage Player</title>
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
                    <asp:Button ID="mngPlayerBtn" runat="server" Text="Manage Player" OnClick="mngPlayerBtn_Click"/>
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

        <div class="MngUsrContent">
            <h1>Player List</h1>
            <br />

            <table style="width:1100px">
                <tr>
                    <th>ID</th>
                    <th>Name</th>
                    <th>Image</th>
                    <th>Nationality</th>
                    <th>Club</th>
                    <th>Age</th>
                    <th>Price</th>
                    <th>Position ID <a href="ViewPlayerPosition.aspx">?</a></th>
                    <th colspan="2">Actions</th>
                </tr>

                <asp:Repeater ID="Repeater1" runat="server">
                    <ItemTemplate>
                        <tr>
                            <td><asp:Label ID="Label1" runat="server" Text='<%# Eval("PlayerID") %>'></asp:Label></td>
                            <td><asp:Label ID="Label2" runat="server" Text='<%# Eval("Name") %>'></asp:Label></td>
                            <td><asp:Image ID="Image2" runat="server" ImageUrl='<%# Eval("Image") %>' style="border-radius:20px; width:100px; height:150px"/></td>
                            <td><asp:Label ID="Label3" runat="server" Text='<%# Eval("Nationality") %>'></asp:Label></td>
                            <td><asp:Label ID="Label7" runat="server" Text='<%# Eval("Club") %>'></asp:Label></td>
                            <td><asp:Label ID="Label4" runat="server" Text='<%# Eval("Age") %>'></asp:Label></td>
                            <td><asp:Label ID="Label5" runat="server" Text='<%# Eval("Price") %>'></asp:Label></td>
                            <td><asp:Label ID="Label6" runat="server" Text='<%# Eval("PositionID") %>'></asp:Label></td>  
                            <td><a href="UpdatePlayer.aspx?id=<%# Eval("PlayerID") %>">Update</a></td>
                            <td><a href="DeletePlayer.aspx?id=<%# Eval("PlayerID") %>">Delete</a></td>
                        </tr>               
                    </ItemTemplate>
                </asp:Repeater>
            </table>

            <p>Add new player? Click <a href="InsertPlayer.aspx">Here</a></p>
        </div>

        <div class="footer">
            <h5>&copy 2021 Hadinata Games.</h5>
        </div>
    </form>
</body>
</html>
