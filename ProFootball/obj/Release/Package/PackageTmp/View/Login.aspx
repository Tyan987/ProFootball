<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="ProFootball.View.Login" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Login</title>
    <link href="Style.css" rel="stylesheet"/>
</head>
<body>
    <form id="form1" runat="server">
        <div class="loginBox">
            <h1>Login</h1>

            <asp:TextBox ID="emailTxt" runat="server" placeholder="Email" style="width:97%"></asp:TextBox>
            <br /><br />
            <asp:TextBox ID="passTxt" runat="server" placeholder="Password" TextMode="Password" style="width:97%"></asp:TextBox>
            <br /><br />
            <asp:CheckBox ID="rememberMe" runat="server" Text="Remember Me" style="margin-left:31%"/>

            <p><asp:Label ID="lblError" runat="server" Text="" style="color:red"></asp:Label></p>

            <asp:Button ID="loginBtn" runat="server" Text="Login" OnClick="loginBtn_Click"/>
            <br />

            <p>Don't have an account? Click <a href="Register.aspx">Here</a></p>
            <p><a href="ForgotPassword.aspx" style="text-decoration:none; color:black">Forgot Password?</a></p>
    </div>
    </form>
</body>
</html>
