using Estudos5.Entities.Exceptions;

namespace Estudos5.Entities
{
    internal class Account
    {
        public int Number { get; private set; }
        public string Holder { get; set; }
        public double Balance { get; private set; }
        public double WithdrawLimit { get; private set; }


        public Account(int number, string holder, double balance, double withdrawLimit)
        {
            Number = number;
            Holder = holder;
            Balance = balance;
            WithdrawLimit = withdrawLimit;
        }

        public void deposit(double amount)
        {
            Balance += amount;
        }

        public void withdraw(double amount)
        {
            if (amount > WithdrawLimit)
            {
                throw new AccountException("The amount exceeds withdraw limit");
            }

            if (amount > Balance)
            {
                throw new AccountException("Not enough balance");
            }

            Balance -= amount;
        }
    }
}
