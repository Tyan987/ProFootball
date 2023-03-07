using ProFootball.Handler;
using ProFootball.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProFootball.Controller
{
    public class AuthController
    {
        public static object Session { get; private set; }

        public static string Login(string email, string pass, bool remember)
        {
            if (remember)
            {
                HttpCookie cookie = new HttpCookie("userCookie");
            }

            if (email.Equals("admin@admin.com") && pass.Equals("admin"))
            {
                return "admin";
            }

            return "";
        }

        public static User LoginUsr(string email, string password)
        {
            return UserHandler.Login(email, password);
        }

        public static string ForgotPassword(string email, string emailInpt, string firstName, string lastName, string newPass, string conPass, DateTime DOB, string captcha, string confCaptcha)
        {
            if (emailInpt.Equals("") || newPass.Equals("") || conPass.Equals(""))
            {
                return "All fields must be filled";
            }

            if (!emailInpt.Contains("@") && !emailInpt.EndsWith(".com"))
            {
                return "Email use wrong format";
            }

            if (!emailInpt.Equals(email)){
                return "user not found";
            }

            if (newPass.Length < 8 || newPass.Length > 16)
            {
                return "Password must be between 8 and 16 character";
            }

            if (conPass.Length < 8 || conPass.Length > 16)
            {
                return "Password must be between 8 and 16 character";
            }

            if (!newPass.Equals(conPass))
            {
                return "New password must be same";
            }

            if (!captcha.Equals(confCaptcha))
            {
                return "Wrong Captcha";
            }

            return UserHandler.UpdateUser(email, firstName, lastName, newPass, DOB);
        }
    }
}