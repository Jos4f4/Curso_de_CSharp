using System;
using System.Collections.Generic;

namespace Listas
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> list = new List<string>();
            list.Add("Maria");
            list.Add("João");
            list.Insert(2, "KKK");
            list.Remove("KKK");


            foreach (string obj in list)
            {
                Console.WriteLine(obj);
            }

            Console.WriteLine("List Count: " + list.Count);
        }
    }
}