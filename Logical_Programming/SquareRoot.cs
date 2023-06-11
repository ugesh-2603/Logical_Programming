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
            if (i < 0) // Check if the input is a non-negative number
            {
                Console.WriteLine("Input must be a non-negative number.");
            }
            double epsilon = 1e-15; // Define a small value for the calculation
            double t = i;
            while (Math.Abs(t - i / t) > epsilon * t) // Perform an iterative calculation 
            {
                t = (i / t + t) / 2.0;  // Update the value of 't' using the approximating square roots
            }
            return t;  // Return the final rep of the square root
        }
    }
}
