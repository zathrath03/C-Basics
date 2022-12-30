using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MySuperBank
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            var account = new BankAccount("John", 10000);
            Console.WriteLine($"Account {account.Number} was created for {account.Owner} with a balance of {account.Balance}");
            
            
        }
    }
}
