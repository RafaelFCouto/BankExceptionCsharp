using System.Globalization;
using Bank_Excep.Entities.Exception;

namespace Bank_Excep.Entities
{
    internal class Account
    {
        public int Number { get; private set; }
        public string Holder { get; private set; }

        public double  Balance { get; private set; }

        public double WithdrawLimit { get; private set; }


        public Account() { }

        public Account(int number, string holder, double balance, double withdrawLimit)
        {
            Number = number;
            Holder = holder;
            Balance = balance;
            WithdrawLimit = withdrawLimit;
        }


        public void Deposit (double amount)
        {
            Balance += amount;
        }

        public void Withdraw (double amount)
        {

            if (amount > WithdrawLimit)
            {
                throw new DomainException("the reported withdrawal amount is higher than the limit ");

            }
            if(amount > Balance)
            {
                throw new DomainException("you don't have a balance");
            }

            Balance -= amount;
            
           

        }


        public override string ToString()
        {
            return Number
                + ", Holder: "
                + Holder
                + ", Balance: "
                + Balance.ToString("F2", CultureInfo.InvariantCulture)
                + ", Withdraw limit: "
                + WithdrawLimit.ToString("F2", CultureInfo.InvariantCulture);

        }





    }
}
