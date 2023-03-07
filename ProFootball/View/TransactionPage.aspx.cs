﻿using ProFootball.Controller;
using ProFootball.Factory;
using ProFootball.Model;
using ProFootball.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ProFootball.View
{
    public partial class TransactionPage : System.Web.UI.Page
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
                    Image1.ImageUrl = ply.Image;
                    nationalityTxt.Text = ply.Nationality;
                    clubTxt.Text = ply.Club;
                    ageTxt.Text = ply.Age.ToString();
                    priceTxt.Text = ply.Price.ToString();
                    positionTxt.Text = ply.PlayerPosition.PositionName;
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

        protected void buyBtn_Click(object sender, EventArgs e)
        {
            int qty = int.Parse(qtyTxt.Text);
            string email = "";

            Model.User usr;
            usr = (Model.User)Session["user"];
            email = usr.Email;

            Transaction trh = TransactionFactory.CreateTransaction(email, DateTime.Today);
            TransactionRepository.InsertTransaction(trh);

            TransactionDetail trhDet = TransactionDetailFactory.CreateTransaction(trh.TransactionID, ply.PlayerID, qty);
            TransactionDetailRepository.InsertTransactionDetail(trhDet);

            Response.Redirect("ViewPlayer.aspx");
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