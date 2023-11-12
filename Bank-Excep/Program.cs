using Bank_Excep.Entities;
using System;
using System.Globalization;



namespace Bank_Excep
{

    class Program
    {

        static void Main(string[] args)
        {

            Console.WriteLine("Enter account data: ");
            Console.Write("Number: ");
            int accountNumber = int.Parse(Console.ReadLine());
            Console.Write("Holder: ");
            string accountHolder = Console.ReadLine();
            Console.Write("Initial balance: ");
            double accountBalance = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("Withdraw limit: ");
            double withdrawLimit = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Account account = new Account(accountNumber,accountHolder, accountBalance, withdrawLimit);

            Console.WriteLine();

            Console.WriteLine("Account data: " + account);

            Console.WriteLine();

            Console.Write("Enter amount for withdraw: ");
            double amount = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            account.Withdraw(amount);

            Console.WriteLine(account);













        }
    }

}