using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logical_Programming
{
    internal class Fibonacci_Series
    {
        public static void Fibonacciseries(int n)
        {

            int firstnumber = 0;
            int secondnumber = 1;

            Console.WriteLine("Fibonacci Series:");
            Console.Write(firstnumber + " " + secondnumber);

            for (int i = 2; i < n; i++)
            {
                int next = firstnumber + secondnumber;
                Console.Write(" " + next);
                firstnumber = secondnumber;
                secondnumber = next;
            }
        }
    }
}
