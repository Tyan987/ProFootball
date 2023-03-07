<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Home.aspx.cs" Inherits="ProFootball.View.Home" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Home</title>
    <link href="Style.css" rel="stylesheet"/>
    <script type="text/javascript" src="script.js"></script>
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
                            <asp:Button ID="logoutBtn" runat="server" Text="Logout" OnClick="logoutBtn_Click"/>
                        </div>
                </div>
            </div>
        </div>

        <div class="homeContent">
            <!-- Slideshow container -->
            <div class="slideshow-container">
              <!-- Full-width images with number and caption text -->
              <div class="mySlides fade">
                <div class="numbertext">1 / 4</div>
                    <img src="RecentEvent1.jpg" style="width:100%; border-radius:30px"/>
              </div>

              <div class="mySlides fade" style="display:none">
                <div class="numbertext">2 / 4</div>
                    <img src="RecentEvent2.jpg" style="width:100%; border-radius:30px"/>
              </div>

              <div class="mySlides fade" style="display:none">
                <div class="numbertext">3 / 4</div>
                    <img src="RecentEvent3.jpg" style="width:100%; border-radius:30px"/>
              </div>

              <div class="mySlides fade" style="display:none">
                <div class="numbertext">4 / 4</div>
                    <img src="RecentEvent4.jpg" style="width:100%; border-radius:30px"/>
              </div>

              <!-- Next and previous buttons -->
              <a class="prev" onclick="plusSlides(-1)">&#10094;</a>
              <a class="next" onclick="plusSlides(1)">&#10095;</a>
            </div>
            <br/>

            <!-- The dots/circles -->
            <div style="text-align:center">
              <span class="dot" onclick="currentSlide(1)"></span>
              <span class="dot" onclick="currentSlide(2)"></span>
              <span class="dot" onclick="currentSlide(3)"></span>
            </div>

            <p>
                eFootball (formerly referred to as Pro Evolution Soccer and Winning Eleven[a] in Japan) is a series of association football simulation video games developed and published by Konami since 1995. 
                It consists of eighteen main instalments and several spin-off style titles that have been released on many different platforms. The series has consistently achieved critical and commercial success.

                eFootball has also been used in esports. eFootball.Open (previously named PES World Finals or PES League) is the esports world championship held by Konami annually since 2010.

                In association football circles, eFootball has a longstanding rivalry with EA's FIFA series.[1] eFootball is the second largest association football video game franchise after FIFA, with the rivalry 
                between the two franchises considered the "greatest rivalry" in the history of sports video games.[2] Listed as one of the best-selling video game franchises, the eFootball series has sold 111 million 
                copies worldwide, in addition to 400 million mobile game downloads, as of December 2020.[3] Konami also created a similar mobile game called PESCM or Pro Evolution Soccer Club Manager.
            </p>
        </div>

        <div class="footer">
            <h5>&copy 2021 Hadinata Games.</h5>
        </div>
    </form>
</body>
</html>
