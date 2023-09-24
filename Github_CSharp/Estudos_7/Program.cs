using Estudos5.Entities;
using Estudos5.Entities.Exceptions;
using System.Collections.Generic;
using System.Globalization;

namespace Course
{
    class ContaExercicio
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Enter account data");

                Console.Write("Number: ");
                int number = int.Parse(Console.ReadLine());

                Console.Write("Holder: ");
                string holder = Console.ReadLine();

                Console.Write("Initial Balance: ");
                double initialBalance = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                Console.Write("Withdraw limit: ");
                double withdrawLimit = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                Account account = new Account(number, holder, initialBalance, withdrawLimit);

                Console.WriteLine();

                Console.Write("Enter amount for withdraw: ");
                double amount = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                account.withdraw(amount);

                Console.WriteLine($"New balance: {account.Balance}");
            }
            catch (AccountException e)
            {
                Console.WriteLine("Withdraw error: " + e.Message);
            }
        }
    }
}