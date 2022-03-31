using System;

namespace BankEncapsulation
{
    class Program
    {
        static void Main(string[] args)
        {
            var userBankAccount = new BankAccount();

            userBankAccount.Deposit();

            Console.WriteLine($"\nYour current balance is ${userBankAccount.GetBalance()}");
        }
    }
}
