using System;

namespace LogicaProgramacao
{
    class Program
    {
        static void Main(string[] args)
        {
            int n1 = int.MinValue;
            int n2 = int.MaxValue;
            double saldo = 10.98989898;

            Console.WriteLine(n1 + " == " + n2);
            Console.WriteLine(saldo.ToString("F2"));

            int a = 10;

            a += 5;
            Console.WriteLine(a);

        }
    }
}