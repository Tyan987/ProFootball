<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Register.aspx.cs" Inherits="ProFootball.View.Register" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Register</title>
    <link href="Style.css" rel="stylesheet"/>
</head>
<body>
    <form id="form1" runat="server">
        <div class="UsrFormContent">
            <h1>Register</h1>

            <asp:TextBox ID="emailTxt" runat="server" placeHolder="Email" style="width:97%"></asp:TextBox>
            <br /><br /> 

            <asp:TextBox ID="FnameTxt" runat="server" placeHolder="Firstname" style="width:97%"></asp:TextBox>
            <br /><br />

            <asp:TextBox ID="LnameTxt" runat="server" placeHolder="Lastname" style="width:97%"></asp:TextBox>
            <br /><br />

            <asp:TextBox ID="passTxt" runat="server" TextMode="Password" placeHolder="Password (8 - 12 Characters)" style="width:97%"></asp:TextBox>
            <br /><br />

            <asp:TextBox ID="dobTxt" runat="server" placeHolder="Date of Birth (dd/mm/yyy)" style="width:97%"></asp:TextBox>
            <br /><br />

            <p><asp:Label ID="LblMsg" runat="server" Text=""></asp:Label></p>
            <br />

            <asp:Button ID="registerBtn" runat="server" Text="Register" OnClick="registerBtn_Click"/>
        </div>
    </form>
</body>
</html>
