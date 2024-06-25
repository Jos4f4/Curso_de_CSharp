﻿using System;
using System.IO
    ;
namespace Arquivos
{
    class ProgramTree
    {
        static void Main(string[] args)
        {
            string path = @"File path";
            try
            {
                using(StreamReader sr = File.OpenText(path)){
                    while (!sr.EndOfStream)
                    {
                        string line = sr.ReadLine();
                        Console.WriteLine(line);
                    }
                }
            }
            catch(IOException e)
            {
                Console.WriteLine("An error ocurreted");
                Console.WriteLine(e.Message);
            }
        }
    }
}
