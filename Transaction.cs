using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TBank
{
    public class Transaction
    {
        //Define Transaction attributes
        private static int TransactionIdSeed = 1000000000;
        public string TxID { get; }
        public DateTime TxDate { get; }
        public decimal TxAmount { get; }
        public string TxNotes { get; }

        //Constructor
        public Transaction(decimal amount, DateTime date, string note)
        {
            TransactionIdSeed++;
            this.TxID = TransactionIdSeed.ToString();
            this.TxDate = date;
            this.TxAmount = amount;
            this.TxNotes = note;
        }
    }
}
