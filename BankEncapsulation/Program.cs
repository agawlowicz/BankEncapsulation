using System;

namespace BankEncapsulation
{
    class Program
    {
        static void Main(string[] args)
        {
            var userBankAccount = new BankAccount();

            bool isValid;
            double depositResult;

            do
            {
                Console.WriteLine("How much money would you like to deposit?");
                isValid = double.TryParse(Console.ReadLine(), out depositResult);
            } while (!isValid);

            userBankAccount.Deposit(depositResult);

            Console.WriteLine($"\nYour current balance is ${userBankAccount.GetBalance()}");
        }
    }
}
