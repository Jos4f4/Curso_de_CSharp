using Heranca.entitites;
using System;

namespace Heranca
{
    class Program
    {
        static void Main(string[] args)
        {
            BusinessAccount account = new BusinessAccount(8010, "Bob Brown", 100.0, 500.0);

            Console.WriteLine(account.Balance);

            //============================
            Account acc = new Account(1001, "Alex", 0.0);
            BusinessAccount bacc = new BusinessAccount(1002, "Maria", 0.0, 500.0);

            //UPCASTING
            Account acc1= bacc;
            Account acc2 = new BusinessAccount(1003, "Bob", 0.0, 200.0);
            Account acc3 = new SavingsAccount(1004, "Anna", 0.0, 0.01);

            //DOWNCASTING
            BusinessAccount acc4 = (BusinessAccount)acc2;

            //=============================

            Account acc10 = new Account(1001, "Alex", 500.0);
            Account acc11 = new SavingsAccount(1001, "Anna", 500.0, 0.01);

            acc10.Withdraw(10.0);
            acc11.Withdraw(10.0);
            Console.WriteLine(acc10.Balance);
            Console.WriteLine(acc11.Balance);

        }
    }
}