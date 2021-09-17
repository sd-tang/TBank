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

            // Make a transaction
            account.MakeWithdrawal(899, DateTime.Now, "Hisense Refrigerator");
            Console.WriteLine($"\n Your current balance: {account.Balance}");
            account.MakeDeposit(500, DateTime.Now, "Unit rental");
            Console.WriteLine($"\n Your current balance: {account.Balance}");

            // Print Account History
            Console.WriteLine($"\n\nAccount Summary for {account.Owner}");
            Console.WriteLine($"\n{account.GetAccountHistory()}");

            // Create some giftcard transactions
            var giftCard = new GiftCardAccount("BigW", 100, 50);
            giftCard.MakeWithdrawal(30, DateTime.Now, "Books");
            giftCard.MakeWithdrawal(50, DateTime.Now, "Grocery");
            giftCard.PerformMonthEndTransaction();
            giftCard.MakeDeposit(35.50m, DateTime.Now, "Top-up");
            Console.WriteLine($"\nGiftCard Account Summary\n\n{giftCard.GetAccountHistory()}");

            // Create some OnelineSaver transactions
            var savings = new OnlineSaverAccount("House", 5000);
            savings.MakeDeposit(2000, DateTime.Now, "savings from salary");
            savings.MakeWithdrawal(950, DateTime.Now, "buy washer combo");
            savings.PerformMonthEndTransaction();
            Console.WriteLine($"\nOnline Saver ({savings.Owner}) Account Summary\n\n{savings.GetAccountHistory()}");

            // Test LineOfCredit limits
            var lineOfCredit = new LineOfCreditAccount("line of credit", 0);
            // How much is too much to borrow?
            lineOfCredit.MakeWithdrawal(1000m, DateTime.Now, "Take out monthly advance");
            lineOfCredit.MakeDeposit(50m, DateTime.Now, "Pay back small amount");
            lineOfCredit.MakeWithdrawal(5000m, DateTime.Now, "Emergency funds for repairs");
            lineOfCredit.MakeDeposit(150m, DateTime.Now, "Partial restoration on repairs");
            lineOfCredit.PerformMonthEndTransaction();
            Console.WriteLine(lineOfCredit.GetAccountHistory());

            // Test initial balance must be positive
            //BankAccount invalidAccount;
            //try
            //{
            //    invalidAccount = new BankAccount("invalid", -300);
            //}
            //catch (ArgumentOutOfRangeException e)
            //{
            //    Console.WriteLine("\n\nException caught creating account with negative value");
            //    Console.WriteLine($"\n{e.ToString()}");
            //    //return;
            //}

            //// Test for a negative balance
            //try
            //{
            //    account.MakeWithdrawal(1800, DateTime.Now, "Attempt to over-withdraw");
            //}
            //catch (InvalidOperationException e)
            //{
            //    Console.WriteLine("\n\nException caught trying to over-withdraw");
            //    Console.WriteLine($"\n{e.ToString()}");
            //}
        }
    }
}
