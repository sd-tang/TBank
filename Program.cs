using System;

namespace TBank
{
    class Program
    {
        static void Main(string[] args)
        {
            var account = new BankAccount("Iris Kua", 2000);
            Console.WriteLine($"Congratulations! A new TBank account has been created for you {account.Owner} with the amount ${account.Balance}\n" +
                $"Your TBank account number is {account.Number}");

            //Make a transaction
            account.MakeWithdrawal(899, DateTime.Now, "Hisense Refrigerator");
            Console.WriteLine($"\n Your current balance: {account.Balance}");
            account.MakeDeposit(500, DateTime.Now, "Unit rental");
            Console.WriteLine($"\n Your current balance: {account.Balance}");

            //Test initial balance must be positive
            BankAccount invalidAccount;
            try
            {
                invalidAccount = new BankAccount("invalid", -300);
            }
            catch (ArgumentOutOfRangeException e)
            {
                Console.WriteLine("\n\nException caught creating account with negative value");
                Console.WriteLine($"\n{e.ToString()}");
                //return;
            }

            //Test for a negative balance
            try
            {
                account.MakeWithdrawal(1800, DateTime.Now, "Attempt to over-withdraw");
            }
            catch (InvalidOperationException e)
            {
                Console.WriteLine("\n\nException caught trying to over-withdraw");
                Console.WriteLine($"\n{e.ToString()}");
            }
        }
    }
}
