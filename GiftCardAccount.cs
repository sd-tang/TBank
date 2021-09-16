using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TBank
{
    public class GiftCardAccount : BankAccount
    {
        //Define attributes
        private decimal _monthlyDeposit = 0m; //name private attributes with _ to prevent calling by mistake, and as a collection of privates

        //Constructor

        public GiftCardAccount(string name, decimal initialBalance, decimal monthlyDeposit = 0) : base(name, initialBalance)
            => _monthlyDeposit = monthlyDeposit;
    }
}
