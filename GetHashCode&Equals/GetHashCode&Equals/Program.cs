using System;
using GetHashCode_Equals.entities;

namespace Course
{
    class Program
    {
        static void Main(string[] args)
        {
            Cliente a = new Cliente { Name = "Maria", Email = "Maria@gmmail.com" };
            Cliente b = new Cliente { Name = "Maria", Email = "Maria@gmmail.com" };

            Console.WriteLine(a.Equals(b));
            Console.WriteLine(a.GetHashCode());
            Console.WriteLine(b.GetHashCode());
        }
    }
}