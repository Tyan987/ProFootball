using ProFootball.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProFootball.Factory
{
    public class TransactionFactory
    {
        public static Transaction CreateTransaction(string email, DateTime date)
        {
            Transaction trn = new Transaction();
            trn.Date = date;
            trn.Email = email;

            return trn;
        }
    }
}