using ProFootball.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProFootball.Factory
{
    public class UserFactory
    {
        public static User CreateUser(string email, string firstName, string lastName, string password, DateTime dob)
        {
            User usr = new User();
            usr.Email = email;
            usr.Firstname = firstName;
            usr.Lastname = lastName;
            usr.Password = password;
            usr.DOB = dob;

            return usr;
        }
    }
}