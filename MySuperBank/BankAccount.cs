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

        public decimal Balance
        {
            get
            {
                decimal balance = 0;
                foreach (var transaction in _allTransactions)
                {
                    balance += transaction.Amount;
                }
                return balance;
            }
        }

        private static int _accountNumberSeed = 1234567890;

        private readonly List<Transaction> _allTransactions = new List<Transaction>();

        public BankAccount(string ownerName, decimal initialDeposit)
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
