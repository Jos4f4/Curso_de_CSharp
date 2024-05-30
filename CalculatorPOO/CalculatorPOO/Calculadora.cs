using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorPOO
{
    class Calculadora
    {
        public static double Pi = 3.14;
        public static double Circunferencia(double r)
        {
            return 2.0 * double.Pi * r;
        }

        public static double Volume(double r)
        {
            return 4.0 / 3.0 * double.Pi * r * r * r;
        }
    }
}
