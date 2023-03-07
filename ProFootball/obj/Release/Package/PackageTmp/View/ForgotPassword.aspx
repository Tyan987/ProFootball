<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ForgotPassword.aspx.cs" Inherits="ProFootball.View.ForgotPassword" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Forgot Password</title>
    <link href="Style.css" rel="stylesheet"/>
</head>
<body>
    <form id="form1" runat="server">       
        <div class="UsrFormContent">
            <h1>Forgot Password</h1>

            <asp:TextBox ID="emailTxt" runat="server" placeHolder="Email" style="width:97%"></asp:TextBox>
            <br /><br />

            <asp:TextBox ID="passTxt" runat="server" TextMode="Password" placeHolder="Password (8 - 12 Characters)" style="width:97%"></asp:TextBox>
            <br /><br />

            <asp:TextBox ID="conPasTxt" runat="server" TextMode="Password" placeHolder="Confirm Password" style="width:97%"></asp:TextBox>
            <br /><br />

            <asp:Button ID="randBtn" runat="server" OnClick="randBtn_Click" Text="Captcha"/>
            <asp:Label ID="lblRandomCaptcha" runat="server" Text="" style="font-size:x-large; margin-left:23%"></asp:Label>
            <br /><br />

            <asp:TextBox ID="txtPass" runat="server" placeHolder="Captcha" style="width:97%"></asp:TextBox>
            <br /><br />

            <p><asp:Label ID="LblMsg" runat="server" Text=""></asp:Label></p>
            <br />

            <asp:Button ID="SubmitBtn" runat="server" OnClick="SubmitBtn_Click" Text="Submit"/>
        </div>
    </form>
</body>
</html>
