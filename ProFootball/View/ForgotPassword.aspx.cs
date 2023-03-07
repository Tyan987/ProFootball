using ProFootball.Controller;
using ProFootball.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ProFootball.View
{
    public partial class ForgotPassword : System.Web.UI.Page
    {
        static User usr;

        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void randBtn_Click(object sender, EventArgs e)
        {
            Random r = new Random();
            const string chars = "abcdefghijklmnopqrstuvwxyz";
            String randomString = new string(Enumerable.Repeat(chars, 3).Select(s => s[r.Next(s.Length)]).ToArray());

            lblRandomCaptcha.Text = randomString + Convert.ToString(r.Next(100, 999));
        }

        protected void SubmitBtn_Click(object sender, EventArgs e)
        {
            usr =  UserController.FindByEmail(emailTxt.Text);

            if(usr == null)
            {
                LblMsg.Text = "All field must be field";
            }

            else
            {
                string email = emailTxt.Text;
                string newPass = passTxt.Text;
                string conPass = conPasTxt.Text;
                string confCaptcha = txtPass.Text;
                string captcha = lblRandomCaptcha.Text;
                string msg = "";

                msg = AuthController.ForgotPassword(usr.Email, email, usr.Firstname, usr.Lastname, newPass, conPass, usr.DOB, captcha, confCaptcha);

                if (msg.Equals(""))
                {
                    LblMsg.Text = "Password Successfully Changed! ";
                }
                else
                {
                    LblMsg.Text = msg;
                }
            }        
        }
    }
}