using System;

namespace TBank
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                var account = new BankAccount("Iris Kua", 35000);
                Console.WriteLine($"Congratulations! A new TBank account has been created for you {account.Owner} with the amount ${account.Balance}\n" +
                $"Your TBank account number is {account.Number}");

                //Make some transactions and display balance
                account.MakeWithdrawal(899, DateTime.Now, "Hisense Refrigerator");
                Console.WriteLine($"\n Your current balance: {account.Balance}");
                account.MakeDeposit(500, DateTime.Now, "Miri rental");
                Console.WriteLine($"\n Your current balance: {account.Balance}");
            }
            catch (ArgumentOutOfRangeException e)
            {
                Console.WriteLine("\nException caught creating account with negative value");
                Console.WriteLine($"\n{e.ToString()}");
                return;
            }
            //var account = new BankAccount("Iris Kua", -2000);
            //Console.WriteLine($"Congratulations! A new TBank account has been created for you {account.Owner} with the amount ${account.Balance}\n" +
            //    $"Your TBank account number is {account.Number}");

            //Make a transaction
            //account.MakeWithdrawal(899, DateTime.Now, "Hisense Refrigerator");
            //Console.WriteLine($"\n Your current balance: {account.Balance}");
            //account.MakeDeposit(500, DateTime.Now, "Miri rental");
            //Console.WriteLine($"\n Your current balance: {account.Balance}");

            //Test initial balance to be positive
            //BankAccount invalidAccount;
            //try
            //{
            //    invalidAccount = new BankAccount("invalid", -300);
            //}
            //catch (ArgumentOutOfRangeException e)
            //{
            //    Console.WriteLine("\nException caught creating account with negative value");
            //    Console.WriteLine($"\n{e.ToString()}");
            //    return;
            //}
        }
    }
}
