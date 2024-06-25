using System;
using System.IO
    ;
namespace Arquivos
{
    class ProgramTwo
    {
        static void Main(string[] args)
        {
            string path = @"File path";
            FileStream fs = null;
            StreamReader sr = null;

            try
            {
                fs = new FileStream(path, FileMode.Open);
                sr = new StreamReader(fs);
                string line = sr.ReadLine();
                Console.WriteLine(line);
            }
            catch (IOException e)
            {
                Console.WriteLine("An error ocurretes");
                Console.WriteLine(e.Message);
            }
            finally
            {
                if (sr! = null) sr.Close();
                if (fs != null) fs.Close();
            }
        }
    }
}
