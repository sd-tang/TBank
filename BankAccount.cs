using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TBank
{
    public class BankAccount
    {
        // Define BankAccount attributes
        private static int accountNumberSeed = 1234509876;
        public string Number { get; }
        public string Owner { get; set; }
        public decimal Balance
        {
            get
            {
                decimal balance = 0;
                foreach(var item in allTransactions)
                {
                    balance += item.TxAmount;
                }
                return balance;
            }
        }

        // Define constructor to initialize this object
        public BankAccount(string name, decimal initialBalance)
        {
            this.Owner = name;
            accountNumberSeed++;
            this.Number = accountNumberSeed.ToString();
            MakeDeposit(initialBalance, DateTime.Now, "Initial Balance");
        }

        private List<Transaction> allTransactions = new List<Transaction>();

        // Define actions/methods for BankAccount object
        public void MakeDeposit(decimal amount, DateTime date, string note)
        {
            if (amount <= 0)
            {
                throw new ArgumentOutOfRangeException(nameof(amount), "Deposit amount must be positive");
            }

            var deposit = new Transaction(amount, date, note);
            allTransactions.Add(deposit);
        }

        public void MakeWithdrawal(decimal amount, DateTime date, string note)
        {
            if (amount > Balance)
            {
                throw new InvalidOperationException("Insufficient funds");
            }

            if (amount <= 0)
            {
                throw new ArgumentOutOfRangeException(nameof(amount), "Withdraw amount cannot be of zero or negative value");
            }

            var withdrawal = new Transaction(-amount, date, note);
            allTransactions.Add(withdrawal);

        }

        // Virtual method
        public virtual void PerformMonthEndTransaction() { }

        // Log all transactions
        public string GetAccountHistory()
        {
            var report = new System.Text.StringBuilder();

            decimal balance = 0;
            report.AppendLine("Date\t\tAmount\t\tBalance\t\tNote");
            report.AppendLine("========================================================");

            foreach (var item in allTransactions)
            {
                balance += item.TxAmount;
                report.AppendLine($"{item.TxDate.ToShortDateString()}\t{item.TxAmount}\t\t{balance}\t\t{item.TxNotes}");
            }

            return report.ToString();
        }
    }
}
