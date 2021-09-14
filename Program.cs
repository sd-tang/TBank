using System;

namespace TBank
{
    class Program
    {
        static void Main(string[] args)
        {
            var account = new BankAccount("Iris Kua", 35000);
            Console.WriteLine($"Congratulations! A new TBank account has been created for you {account.Owner} with the amount ${account.Balance}\n" +
                $"Your TBank account number is {account.Number}");

            //Make a transaction
            account.MakeWithdrawal(899, DateTime.Now, "Hisense Refrigerator");
            Console.WriteLine($"\n Your current balance: {account.Balance}");
            account.MakeDeposit(500, DateTime.Now, "Miri rental");
            Console.WriteLine($"\n Your current balance: {account.Balance}");
        }
    }
}
