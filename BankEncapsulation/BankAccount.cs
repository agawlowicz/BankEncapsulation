using System;
namespace BankEncapsulation
{
    public class BankAccount
    {
        public BankAccount()
        {
        }
        private double _balance = 0;

        public void Deposit()
        {
            bool isValid;
            double depositValue;
            do
            {
                Console.WriteLine("How much money would you like to deposit?");
                isValid = double.TryParse(Console.ReadLine(), out depositValue);
            } while (!isValid);

            _balance += depositValue;
        }

        public double GetBalance()
        {
            return _balance;
        }
    }
}
