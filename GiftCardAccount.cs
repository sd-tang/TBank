using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TBank
{
    public class GiftCardAccount : BankAccount
    {
        // Define attributes
        private decimal _monthlyDeposit = 0m; 
        // Naming convention for private attributes: _smallCamel
        
        // Constructor
        public GiftCardAccount(string name, decimal initialBalance, decimal monthlyDeposit = 0) : base(name, initialBalance)
            => _monthlyDeposit = monthlyDeposit;

        public override void PerformMonthEndTransaction()
        {
            if (_monthlyDeposit != 0)
            {
                MakeDeposit(_monthlyDeposit, DateTime.Now, "Monthly deposit");
            }
        }
    }
}
