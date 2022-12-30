using System;

namespace MySuperBank
{
    internal class Program
    {
        private static void Main()
        {
            var account = new BankAccount("John", 10000);
            Console.WriteLine($"Account {account.Number} was created for {account.Owner} with a balance of {account.Balance}");

            account.MakeWithdrawal(120, DateTime.Now, "Programming Course");
            Console.WriteLine(account.Balance);

            try
            {
                account.MakeDeposit(-100, DateTime.Now, "steeling");
            }
            catch (ArgumentOutOfRangeException)
            {
                Console.WriteLine("Correctly rejected negative deposit");
            }

            try
            {
                var unused = new BankAccount("invalid", -55);
            }
            catch (ArgumentOutOfRangeException)
            {
                Console.WriteLine("Correctly rejected negative initial balance");
            }

            try
            {
                account.MakeWithdrawal(100000, DateTime.Now, "steeling");
            }
            catch (InvalidOperationException)
            {
                Console.WriteLine("Correctly rejected withdrawal that results in a negative balance");
            }

            Console.WriteLine(account.GetAccountHistory());

        }
    }
}
