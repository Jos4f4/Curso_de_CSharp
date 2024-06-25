using System;
using System.IO;

namespace Arquivos
{
    class ProgramFour
    {
        static void Main(string[] args)
        {
            string sourcePath = @"File path";
            string targetPath = @"File path";

            try
            {
                string[] lines = File.ReadAllLines(sourcePath);
                using (StreamWriter sw = File.AppendText(targetPath))
                {
                    foreach (string lines in lines)
                    {
                        sw.WriteLine(line.ToUpper());
                    }
                }

            }
            catch (IOException e)
            {
                Console.WriteLine("An error ocurreted");
                Console.WriteLine(e.Message);
            }
        }
    }
}