using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TBank
{
    public class LineOfCreditAccount : BankAccount
    {
        // Constructor
        public LineOfCreditAccount(string name, decimal initialBalance) : base(name, initialBalance)
        {

        }

        public override void PerformMonthEndTransaction()
        {
            if (Balance < 0) //negative balance means owing bank's money
            {
                decimal interest = -Balance * 0.05m;
                MakeWithdrawal(interest, DateTime.Now, "Credit line monthly interest");
            }
        }
    }
}
