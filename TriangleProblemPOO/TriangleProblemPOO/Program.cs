using System;
using System.Globalization;

namespace TriangleProblemPOO
{
    class Program   
    {
        static void Main(string[] args)
        {
            Triangulo x, y;

            x = new Triangulo();
            y = new Triangulo();

            Console.WriteLine("Entre com as medidas do Triângulo X: ");
            x.A = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            x.B = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            x.C = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine("Entre com as medidas do Triângulo Y: ");
            y.A = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            y.B = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            y.C = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double AreaX = x.Area();
            double AreaY = y.Area();

            Console.WriteLine("Área de X: " + AreaX.ToString("F4", CultureInfo.InvariantCulture));
            Console.WriteLine("Área de Y: " + AreaY.ToString("F4", CultureInfo.InvariantCulture));

            if(AreaX > AreaY)
            {
                Console.WriteLine("Maior área: X.");
            }
            else
            {
                Console.WriteLine("Maior área: Y.");
            }

        }
    }
}