using ProFootball.Handler;
using ProFootball.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProFootball.Controller
{
    public class TransactionController
    {
        public static List<Transaction> ViewTransaction()
        {
            List<Transaction> trn = TransactionHandler.ViewTransaction();
            return trn;
        }

        public static List<Transaction> ViewTransactionByUser(string email)
        {
            List<Transaction> trn = TransactionHandler.ViewTransactionByUser(email);
            return trn;
        }

        public static string InsertTransaction(string email, DateTime date)
        {
            return TransactionHandler.InsertTransaction(email, date);
        }

        public static Transaction FindById(int Id)
        {
            return TransactionHandler.FindById(Id);
        }

        public static List<TransactionDetail> ViewTransactionDetail()
        {
            List<TransactionDetail> trnDet = TransactionDetailHandler.ViewTransactionDetail();
            return trnDet;
        }

        public static string InsertTransactionDetail(string trnID, string plyID, string qty)
        {
            int intTrnID = int.Parse(trnID);
            int intPlyID = int.Parse(plyID);
            int intQty = int.Parse(qty);

            return TransactionDetailHandler.InsertTransactionDetail(intTrnID, intPlyID, intQty);
        }
    }
}