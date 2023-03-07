using ProFootball.Factory;
using ProFootball.Model;
using ProFootball.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProFootball.Handler
{
    public class TransactionDetailHandler
    {
        public static string InsertTransactionDetail(int trID, int plyID, int qty)
        {
            TransactionDetail trh = TransactionDetailFactory.CreateTransaction(trID, plyID, qty);
            TransactionDetailRepository.InsertTransactionDetail(trh);

            return "";
        }

        public static List<TransactionDetail> ViewTransactionDetail()
        {
            return TransactionDetailRepository.TransactionDetailList();
        }
    }
}