using System;
namespace BankEncapsulation
{
    public class BankAccount
    {
        public BankAccount()
        {
        }
        private double _balance = 0;

        public void Deposit(double depositValue)
        {
            _balance += depositValue;
        }

        public double GetBalance()
        {
            return _balance;
        }
    }
}
