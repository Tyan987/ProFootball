using ProFootball.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProFootball.Factory
{
    public class TransactionDetailFactory
    {
        public static TransactionDetail CreateTransaction(int tranId, int playerID, int Quantity)
        {
            TransactionDetail trnDet = new TransactionDetail();
            trnDet.TransactionID = tranId;
            trnDet.PlayerID = playerID;
            trnDet.Quantity = Quantity;

            return trnDet;
        }
    }
}