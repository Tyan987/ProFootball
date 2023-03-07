using ProFootball.Controller;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ProFootball.View
{
    public partial class Login : System.Web.UI.Page
    {
        private Model.ProFootballDatabaseEntities db = new Model.ProFootballDatabaseEntities();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Request.Cookies["emailCookie"] != null && Request.Cookies["passCookie"] != null)
            {
                var email = Request.Cookies["emailCookie"].Value;
                var pass = Request.Cookies["passCookie"].Value;
                emailTxt.Text = email;
                passTxt.Text = pass;
                rememberMe.Checked = true;
            }
        }

        protected void loginBtn_Click(object sender, EventArgs e)
        {
            String email = emailTxt.Text;
            String pass = passTxt.Text;
            bool remember = rememberMe.Checked;
            string role = "";

            role = AuthController.Login(email, pass, remember);

            if (role.Equals("admin"))
            {
                Session["user"] = "admin";
                if (remember)
                {
                    HttpCookie cookie = new HttpCookie("userCookie");
                    cookie.Value = "admin";
                }
                Response.Redirect("Home.aspx");
            }

            else
            {
                var user = AuthController.LoginUsr(email, pass);

                if (user != null)
                {
                    Session["user"] = user;
                    if (remember)
                    {
                        HttpCookie emailCookie = new HttpCookie("emailCookie");
                        HttpCookie passCookie = new HttpCookie("passCookie");
                        HttpCookie FnameCookie = new HttpCookie("FnameCookie");
                        HttpCookie LnameCookie = new HttpCookie("LnameCookie");
                        HttpCookie DOBCookie = new HttpCookie("dobCookie");
                        emailCookie.Value = user.Email;
                        passCookie.Value = user.Password;
                        FnameCookie.Value = user.Firstname;
                        LnameCookie.Value = user.Lastname;
                        DOBCookie.Value = user.DOB.ToString();

                        emailCookie.Expires = DateTime.Now.AddDays(1);
                        passCookie.Expires = DateTime.Now.AddDays(1);
                        FnameCookie.Expires = DateTime.Now.AddDays(1);
                        LnameCookie.Expires = DateTime.Now.AddDays(1);
                        DOBCookie.Expires = DateTime.Now.AddDays(1);

                        Response.Cookies.Add(emailCookie);
                        Response.Cookies.Add(passCookie);
                        Response.Cookies.Add(FnameCookie);
                        Response.Cookies.Add(LnameCookie);
                        Response.Cookies.Add(DOBCookie);
                    }
                    Response.Redirect("Home.aspx");
                }

                else
                {
                    lblError.Text = "Wrong email or password!";
                }
            }
        }

    }
}