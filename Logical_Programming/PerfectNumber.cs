using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logical_Programming
{
    internal class PerfectNumber
    {
        public static void Perfect(int k)
        {
            int i , sum = 0;
            for (i = 1; i < k; i++)
            {
                if (k % i == 0)
                {
                    sum = sum + i;
                   
                }
            }
            if (sum == k && k != 1)
                {

                    Console.Write("The Number is Perfect Number");

                }

                else
                {
                    Console.Write("The Number is Not Perfect Number");
                }

                Console.Write("\n");
            
        }
    }
}
