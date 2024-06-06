using System;

namespace TopicsSpecial
{
    class Program
    {
        static void Main(string[] args)
        {
            //switch-case
            int x = int.Parse(Console.ReadLine());

            switch (x)
            {
                case 1: 
                    Console.WriteLine("1");
                    break;
                case 2:
                    Console.WriteLine("1");
                    break;
                case 3:
                    Console.WriteLine("1");
                    break;
                case 4:
                    Console.WriteLine("1");
                    break;
                default:
                    Console.WriteLine("Invalid Value.");
                    break;

            }


            //Data e Hora
            DateTime d1 = new DateTime(2024, 05, 15, 20, 40, 6);
            DateTime d2 =DateTime.Now;
            Console.WriteLine(d1);
            Console.WriteLine(d2);

            TimeSpan t1 = new TimeSpan(0, 1, 30, 15);
            Console.WriteLine(t1);

            //Formato UTC
            DateTime d3 = new DateTime(2000, 8, 15, 13, 5, 58, DateTimeKind.Local);
            DateTime d4 = DateTime.Now;
            Console.WriteLine(d3);
            Console.WriteLine(d4.ToUniversalTime());

            //Padrão ISO 8601

        }
    }
}