using ProFootball.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProFootball.Repository
{
    public class TransactionDetailRepository
    {
        public static List<TransactionDetail> TransactionDetailList()
        {
            ProFootballDatabaseEntities db = new ProFootballDatabaseEntities();
            return (from trnDet in db.TransactionDetails select trnDet).ToList();
        }

        public static void InsertTransactionDetail(TransactionDetail trnDet)
        {
            ProFootballDatabaseEntities db = new ProFootballDatabaseEntities();
            db.TransactionDetails.Add(trnDet);
            db.SaveChanges();
        }
    }
}