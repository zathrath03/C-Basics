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
            Number = _accountNumberSeed++.ToString();

            MakeDeposit(initialDeposit, DateTime.Now, "Initial Balance");
        }

        public void MakeDeposit(decimal amount, DateTime date, string note)
        {
            if (amount < 0)
            {
                throw new ArgumentOutOfRangeException(nameof(amount), "Amount of deposit must be positive");
            }

            var deposit = new Transaction(amount, date, note);
            _allTransactions.Add(deposit);
        }

        public void MakeWithdrawal(decimal amount, DateTime date, string note)
        {
            if (amount <= 0)
            {
                throw new ArgumentOutOfRangeException(nameof(amount), "Amount of withdrawal must be positive");

            }
            if (Balance - amount < 0)
            {
                throw new InvalidOperationException("Insufficient funds for this withdrawal");
            }
            var withdrawal = new Transaction(-amount, date, note);
            _allTransactions.Add(withdrawal);
        }
    }
}
