<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ManageUser.aspx.cs" Inherits="ProFootball.View.ManageUser" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Manage User</title>
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

        <div class="MngUsrContent">
            <h1>User List</h1>
            <br />

            <table style="width:1100px">
                <tr>
                    <th>Email</th>
                    <th>First Name</th>
                    <th>Last Name</th>            
                    <th>Password</th>
                    <th>Date of Birth</th>
                    <th colspan="2">Actions</th>
                </tr>

                <asp:Repeater ID="Repeater1" runat="server">
                <ItemTemplate>
                    <tr>
                        <td><asp:Label ID="Label1" runat="server" Text='<%# Eval("Email") %>'></asp:Label></td>
                        <td><asp:Label ID="Label2" runat="server" Text='<%# Eval("Firstname") %>'></asp:Label></td>
                        <td><asp:Label ID="Label3" runat="server" Text='<%# Eval("Lastname") %>'></asp:Label></td>
                        <td><asp:Label ID="Label7" runat="server" Text='<%# Eval("Password") %>'></asp:Label></td>
                        <td><asp:Label ID="Label4" runat="server" Text='<%# Eval("DOB") %>'></asp:Label></td>
                        <td><a href="UpdateUser.aspx?email=<%# Eval("Email") %>">Update</a></td>
                        <td><a href="DeleteUser.aspx?email=<%# Eval("Email") %>">Delete</a></td>
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
