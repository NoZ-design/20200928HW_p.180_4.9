using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace _20200928HW_p._180_4._9
{
    class Account
    {
        public string Name { get; set; }
        private decimal balance;

        public Account(string accountName,decimal initialBalance)
        {
            Name = accountName;
            balance = initialBalance;
        }

        public decimal Balance
        {
            get
            {
                return balance;

            }
            private set
            {
                if(value > 0.0m)
                {
                    balance = value;
                }
            }
        }

        public void Deposit(decimal depositAmount)
        {
            if(depositAmount > 0.0m)
            {
                Balance = Balance + depositAmount;
            }
        }

        public int Withdrawal(decimal WithdrawalAmount)
        {
            if(WithdrawalAmount > 0.0m)
            {
                Balance = Balance - WithdrawalAmount;
                if(Balance < 0.0m)
                {
                    Console.WriteLine($"Withdrawing {WithdrawalAmount:C} would leave you overdrawn!");
                }
            
            }
            return (int)Balance;
        }
    }
}
