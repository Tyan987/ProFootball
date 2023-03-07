using ProFootball.Controller;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ProFootball.View
{
    public partial class Register : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
           
        }

        protected void registerBtn_Click(object sender, EventArgs e)
        {
            string email = emailTxt.Text;
            string Fname = FnameTxt.Text;
            string Lname = LnameTxt.Text;
            string pass = passTxt.Text;
            DateTime DOB = DateTime.Parse(dobTxt.Text);
            string msg = "";

            msg = UserController.InsertUser(email, Fname, Lname, pass, DOB);

            if (msg.Equals(""))
            {
                LblMsg.Text = "Register Successfully! ";
                Response.Redirect("Login.aspx");
            }
            else
            {
                LblMsg.Text = msg;
            }
        }
    }
}