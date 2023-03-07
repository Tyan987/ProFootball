using ProFootball.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProFootball.Repository
{
    public class TransactionRepository
    {
        public static List<Transaction> TransactionList()
        {
            ProFootballDatabaseEntities db = new ProFootballDatabaseEntities();
            return (from trn in db.Transactions select trn).ToList();
        }

        public static List<Transaction> TransactionListByUser(string email)
        {
            ProFootballDatabaseEntities db = new ProFootballDatabaseEntities();
            return (from trn in db.Transactions where trn.Email.Equals(email) select trn).ToList();
        }

        public static Transaction FindById(int Id)
        {
            ProFootballDatabaseEntities db = new ProFootballDatabaseEntities();
            return (from trn in db.Transactions where trn.TransactionID == Id select trn).FirstOrDefault();
        }

        public static void InsertTransaction(Transaction trn)
        {
            ProFootballDatabaseEntities db = new ProFootballDatabaseEntities();
            db.Transactions.Add(trn);
            db.SaveChanges();
        }
    }
}