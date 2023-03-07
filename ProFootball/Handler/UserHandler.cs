using ProFootball.Factory;
using ProFootball.Model;
using ProFootball.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProFootball.Handler
{
    public class UserHandler
    {
        public static List<User> ViewUser()
        {
            List<User> users = UserRepository.UserList();
            return users;
        }

        public static List<User> UserProfile(string email)
        {
            return UserRepository.UserProfile(email);          
        }

        public static User Login(string email, string password)
        {
            return UserRepository.Login(email, password);
        }

        public static string InsertUser(string email, string firstName, string lastName, string password, DateTime DOB)
        {
            bool checkEmail = UserRepository.CheckEmail(email);

            if (checkEmail == false)
            {
                return "Email must be Unique";
            }

            User usr = UserFactory.CreateUser(email, firstName, lastName, password, DOB);
            UserRepository.InsertUser(usr);

            return "";
        }

        public static User FindByEmail(string email)
        {
            return UserRepository.FindByEmail(email);
        }

        public static string UpdateUser(string email, string firstName, string lastName, string password, DateTime DOB)
        {
            UserRepository.UpdateUser(email, firstName, lastName, password, DOB);
            return "";
        }

        public static string DeleteUser(string email)
        {
            bool checkActivity = UserRepository.CheckUserActivity(email);

            if (checkActivity == true)
            {
                return "User Can not delete";
            }

            UserRepository.DeleteUser(email);

            return "";
        }
    }
}