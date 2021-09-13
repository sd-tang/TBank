using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TBank
{
    public class BankAccount
    {
        //Define BankAccount attributes
        private static int accountNumberSeed = 1234509876;
        public string Number { get; }
        public string Owner { get; set; }
        public decimal Balance { get; }

        //Define constructor to initialize this object
        public BankAccount(string name, decimal initialBalance)
        {
            this.Owner = name;
            this.Balance = initialBalance;
            accountNumberSeed++;
            this.Number = accountNumberSeed.ToString();
        }

        //Define actions/methods for BankAccount object
        public void MakeDeposit(decimal amount, DateTime date, string note)
        {

        }

        public void MakeWithdrawal(decimal amount, DateTime date, string note)
        {

        }
    }
}
