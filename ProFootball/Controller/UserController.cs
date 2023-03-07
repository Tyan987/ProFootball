using ProFootball.Handler;
using ProFootball.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProFootball.Controller
{
    public class UserController
    {
        public static List<User> ViewUser()
        {
            List<User> usr = UserHandler.ViewUser();
            return usr;
        }

        public static List<User> UserProfile(string email)
        {
            return UserHandler.UserProfile(email);
        }

        public static User FindByEmail(string email)
        {
            return UserHandler.FindByEmail(email);
        }

        public static string InsertUser(string email, string firstName, string lastName, string password, DateTime DOB)
        {
            if (email.Equals("") || firstName.Equals("") || password.Equals("") || DOB.Equals(""))
            {
                return "All fields must be filled";
            }

            if (!email.Contains("@") && !email.EndsWith(".com"))
            {
                return "Email use wrong format";
            }

            if (firstName.Length < 2)
            {
                return "First Name must more than 2 character";
            }

            if (password.Length < 8 || password.Length > 16)
            {
                return "Password must be between 8 and 16 character";
            }

            return UserHandler.InsertUser(email, firstName, lastName, password, DOB);
        }

        public static string UpdateUser(string email, string firstName, string lastName, string password, DateTime DOB)
        {
            if (email.Equals("") || firstName.Equals("") || password.Equals("") || DOB.Equals(""))
            {
                return "All fields must be filled";
            }

            if (!email.Contains("@") && !email.EndsWith(".com"))
            {
                return "Email use wrong format";
            }

            if (firstName.Length < 2)
            {
                return "First Name must more than 2 character";
            }

            return UserHandler.UpdateUser(email, firstName, lastName, password, DOB);
        }

        public static string ChangePassword(string email, string firstName, string lastName, string password, string oldPass, string newPass, string conPass, DateTime DOB)
        {
            if (password.Equals("") || newPass.Equals("") || conPass.Equals(""))
            {
                return "Password must be filled";
            }

            if (oldPass.Length < 8 || oldPass.Length > 12)
            {
                return "Password must be between 8 and 12 character";
            }

            if(newPass.Length < 8 || newPass.Length > 12)
            {
                return "Password must be between 8 and 12 character";
            }

            if (conPass.Length < 8 || conPass.Length > 12)
            {
                return "Password must be between 8 and 12 character";
            }

            if (!oldPass.Equals(password))
            {
                return "Wrong Old Password";
            }

            if (newPass.Equals(oldPass))
            {
                return "Password can not be same as old Password";
            }

            if (!newPass.Equals(conPass))
            {
                return "New password must be same";
            }

            return UserHandler.UpdateUser(email, firstName, lastName, newPass, DOB);
        }

        public static string DeleteUser(string email)
        {
            return UserHandler.DeleteUser(email);
        }
    }
}