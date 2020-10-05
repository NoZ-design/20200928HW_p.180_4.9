using System;

namespace _20200928HW_p._180_4._9
{
    class AccountTest
    {
        static void Main(string[] args)
        {
            Account account1 = new Account("Jane", 00.00m);
            Account account2 = new Account("Jhon", 00.00m);

            Console.WriteLine($"{account1.Name}'s balance:{account1.Balance:C}");
            Console.WriteLine($"{account2.Name}'s balance:{account2.Balance:C}");

            //account1存錢
            Console.Write("\nEnter deposite amount for account1: ");
            decimal depositAmount = decimal.Parse(Console.ReadLine());
            Console.WriteLine($"adding {depositAmount:C} to account1 balance\n");
            account1.Deposit(depositAmount);

            Console.WriteLine($"{account1.Name}'s balance:{account1.Balance:C}");
            Console.WriteLine($"{account2.Name}'s balance:{account2.Balance:C}");

            //account2存錢
            Console.Write("\nEnter deposite amount for account2: ");
            depositAmount = decimal.Parse(Console.ReadLine());
            Console.WriteLine($"adding {depositAmount:C} to account2 balance\n");
            account2.Deposit(depositAmount);

            Console.WriteLine($"{account1.Name}'s balance:{account1.Balance:C}");
            Console.WriteLine($"{account2.Name}'s balance:{account2.Balance:C}");

            //account1提款
            Console.Write("\nEnter withdrawal amount for account1: ");
            decimal WithdrawalAmount = decimal.Parse(Console.ReadLine());
            Console.WriteLine($"removing {WithdrawalAmount:C} to account1 balance\n");
            account1.Withdrawal(WithdrawalAmount);

            Console.WriteLine($"{account1.Name}'s balance:{account1.Balance:C}");
            Console.WriteLine($"{account2.Name}'s balance:{account2.Balance:C}");

            //account2提款
            Console.Write("\nEnter withdrawal amount for account2: ");
            WithdrawalAmount = decimal.Parse(Console.ReadLine());
            Console.WriteLine($"removing {WithdrawalAmount:C} to account2 balance\n");
            account2.Withdrawal(WithdrawalAmount);
             
            Console.WriteLine($"{account1.Name}'s balance:{account1.Balance:C}");
            Console.WriteLine($"{account2.Name}'s balance:{account2.Balance:C}");
        }
    }
}
