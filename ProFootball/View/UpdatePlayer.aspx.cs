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
    public partial class UpdatePlayer : System.Web.UI.Page
    {
        static Player ply;
        static User usr;

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                ply = PlayerController.FindById(int.Parse(Request.QueryString["id"]));

                if (ply == null)
                {
                    Response.Redirect("./ViewPlayer.aspx");
                }

                else
                {
                    nameTxt.Text = ply.Name;
                    nationalityTxt.Text = ply.Nationality;
                    clubTxt.Text = ply.Club;
                    ageTxt.Text = ply.Age.ToString();
                    priceTxt.Text = ply.Price.ToString();
                    positionTxt.Text = ply.PositionID.ToString();
                }
            }

            if (Session["user"] == null && Request.Cookies["emailCookie"] == null)
            {
                Response.Redirect("Login.aspx");

            }
            else
            {
                if (Session["user"] == null)
                {
                    var email = Request.Cookies["emailCookie"].Value;
                    var pass = Request.Cookies["passCookie"].Value;
                    usr = AuthController.LoginUsr(email, pass);
                    if (usr != null)
                    {
                        Session["user"] = usr;
                        namelbl.Text = usr.Firstname;
                        usrProfileBtn.Visible = true;
                        trnBtn.Visible = true;
                        marketBtn.Visible = true;
                        viewBtn.Visible = true;
                        changePassBtn.Visible = true;
                    }

                    else
                    {
                        Session["user"] = "admin";
                        namelbl.Text = "Admin";
                        mngPlayerBtn.Visible = true;
                        mngUserBtn.Visible = true;
                        viewAllTrnBtn.Visible = true;
                    }
                }
                else
                {
                    try
                    {
                        usr = (Model.User)Session["user"];
                        namelbl.Text = usr.Firstname;
                        usrProfileBtn.Visible = true;
                        trnBtn.Visible = true;
                        marketBtn.Visible = true;
                        viewBtn.Visible = true;
                        changePassBtn.Visible = true;
                    }
                    catch
                    {
                        namelbl.Text = "Admin";
                        mngPlayerBtn.Visible = true;
                        mngUserBtn.Visible = true;
                        viewAllTrnBtn.Visible = true;
                    }
                }
            }
        }

        protected void updateBtn_Click(object sender, EventArgs e)
        {
            string name = nameTxt.Text;
            string image = "";
            string nationality = nationalityTxt.Text;
            string club = clubTxt.Text;
            string age = ageTxt.Text;
            string price = priceTxt.Text;
            string position = positionTxt.Text;
            string extension = "";
            string msg = "";

            if (FileUploadImage.HasFile)
            {
                var file = FileUploadImage.PostedFile;
                extension = System.IO.Path.GetExtension(file.FileName);

                var filePath = HttpContext.Current.Server.MapPath("~/Pictures/" + file.FileName);
                file.SaveAs(filePath);
                image = "../Pictures/" + file.FileName;
            }

            msg = PlayerController.UpdatePlayer(ply.PlayerID, name, image, nationality, club, age, price, position, extension);

            if (msg.Equals(""))
            {
                LblMsg.Text = "Update Player Successfully! ";
            }
            else
            {
                LblMsg.Text = msg;
            }
        }

        protected void viewBtn_Click(object sender, EventArgs e)
        {
            Response.Redirect("ViewPlayer.aspx");
        }

        protected void marketBtn_Click(object sender, EventArgs e)
        {
            Response.Redirect("PlayerMarket.aspx");
        }

        protected void trnBtn_Click(object sender, EventArgs e)
        {
            Response.Redirect("ViewTransactionByUser.aspx");
        }

        protected void mngPlayerBtn_Click(object sender, EventArgs e)
        {
            Response.Redirect("ManagePlayer.aspx");
        }

        protected void mngUserBtn_Click(object sender, EventArgs e)
        {
            Response.Redirect("ManageUser.aspx");
        }

        protected void viewAllTrnBtn_Click(object sender, EventArgs e)
        {
            Response.Redirect("ViewTransaction.aspx");
        }

        protected void usrProfileBtn_Click(object sender, EventArgs e)
        {
            Response.Redirect("UserProfile.aspx");
        }

        protected void changePassBtn_Click(object sender, EventArgs e)
        {
            Response.Redirect("ChangePassword.aspx");
        }

        protected void logoutBtn_Click1(object sender, EventArgs e)
        {
            String[] cookies = Request.Cookies.AllKeys;
            foreach (string cookie in cookies)
            {
                Response.Cookies[cookie].Expires = DateTime.Now.AddDays(-1);
                Session.Remove("user");
            }
            Response.Redirect("Login.aspx");
        }
    }
}