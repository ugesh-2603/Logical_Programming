using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logical_Programming
{
    internal class Temperature_Conversion
    {
        public static void Cel_to_Far(double temp)
        {
            double F = (temp * 9 / 5) + 32;
            Console.WriteLine(temp + "°C in Fahrenheit is: " + F + "°F");
        }

        public static void Far_to_Cel(double temp)
        {
            double C = (temp - 32) * 5 / 9;
            Console.WriteLine(temp + "°F in Celsius is: " + C + "°C");
        }
    }
}
