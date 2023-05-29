using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logical_Programming
{
    internal class SquareRoot
    {
        public static double Sqrt(double i)
        {
            if (i < 0)
            {
                Console.WriteLine("Input must be a non-negative number.");
            }
            double epsilon = 1e-15;
            double t = i;
            while (Math.Abs(t - i / t) > epsilon * t)
            {
                t = (i / t + t) / 2.0;
            }
            return t;
        }
    }
}
