using ProFootball.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProFootball.Repository
{
    public class UserRepository
    {
        public static List<User> UserList()
        {
            ProFootballDatabaseEntities db = new ProFootballDatabaseEntities();
            return (from usr in db.Users select usr).ToList();
        }

        public static List<User> UserProfile(string email)
        {
            ProFootballDatabaseEntities db = new ProFootballDatabaseEntities();
            return (from usr in db.Users where usr.Email.Equals(email) select usr).ToList();
        }

        public static User FindByEmail(string email)
        {
            ProFootballDatabaseEntities db = new ProFootballDatabaseEntities();
            return (from usr in db.Users where usr.Email.Equals(email) select usr).FirstOrDefault();
        }

        public static bool CheckEmail(string email)
        {
            ProFootballDatabaseEntities db = new ProFootballDatabaseEntities();
            User check = (from usr in db.Users where usr.Email.Equals(email) select usr).FirstOrDefault();

            if (check == null) return true;
            else return false;
        }

        public static bool CheckUserActivity(string email)
        {
            ProFootballDatabaseEntities db = new ProFootballDatabaseEntities();
            User check = (from usr in db.Users join trn in db.Transactions on usr.Email equals trn.Email where trn.Email.Equals(email) select usr).FirstOrDefault();

            if (check == null) return false;
            else return true;
        }

        public static void InsertUser(User usr)
        {
            ProFootballDatabaseEntities db = new ProFootballDatabaseEntities();
            db.Users.Add(usr);
            db.SaveChanges();
        }

        public static void UpdateUser(string email, string firstName, string lastName, string password, DateTime DOB)
        {
            ProFootballDatabaseEntities db = new ProFootballDatabaseEntities();
            User update = (from usr in db.Users where usr.Email.Equals(email) select usr).FirstOrDefault();

            update.Email = email;
            update.Firstname = firstName;
            update.Lastname = lastName;
            update.Password = password;
            update.DOB = DOB;

            db.SaveChanges();
        }

        public static void DeleteUser(string email)
        {
            ProFootballDatabaseEntities db = new ProFootballDatabaseEntities();
            User delete = (from usr in db.Users where usr.Email.Equals(email) select usr).FirstOrDefault();

            db.Users.Remove(delete);
            db.SaveChanges();
        }

        public static User Login(string email, string password)
        {
            ProFootballDatabaseEntities db = new ProFootballDatabaseEntities();
            return (from usr in db.Users where usr.Email.Equals(email) && usr.Password.Equals(password) select usr).FirstOrDefault();
        }
    }
}