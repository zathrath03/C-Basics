using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MySuperBank
{
    public class BankAccount
    {

        public string Number { get;  }
        public string Owner { get; set; }
        public decimal Balance { get; }

        private static int _accountNumberSeed = 1234567890;

        public BankAccount(string ownerName, decimal initialBalance)
        {
            Owner = ownerName;
            Balance = initialBalance;
            Number = _accountNumberSeed++.ToString();
        }

        public void MakeDeposit(decimal amount, DateTime date, string note)
        {

        }

        public void MakeWithdrawal(decimal amount, DateTime date, string note) { }
    }
}
