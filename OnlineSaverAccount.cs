using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TBank
{
    public class OnlineSaverAccount : BankAccount
    {
        // Constructor
        public OnlineSaverAccount(string name, decimal initialBalance) : base(name, initialBalance)
        {

        }

        public override void PerformMonthEndTransaction()
        {
            if (Balance > 500m) //m means decimal, m for money
            {
                decimal interest = Balance * 0.02m;
                MakeDeposit(interest, DateTime.Now, "Monthly deposit");
            }
        }
    }
}
