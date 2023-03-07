using ProFootball.Factory;
using ProFootball.Model;
using ProFootball.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProFootball.Handler
{
    public class TransactionHandler
    {
        public static string InsertTransaction(string email, DateTime trdate)
        {
            Transaction trh = TransactionFactory.CreateTransaction(email, trdate);
            TransactionRepository.InsertTransaction(trh);

            return "";
        }

        public static List<Transaction> ViewTransaction()
        {
            return TransactionRepository.TransactionList();
        }

        public static List<Transaction> ViewTransactionByUser(string email)
        {
            return TransactionRepository.TransactionListByUser(email);
        }

        public static Transaction FindById(int Id)
        {
            return TransactionRepository.FindById(Id);
        }
    }
}