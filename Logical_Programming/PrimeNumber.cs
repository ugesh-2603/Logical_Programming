using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logical_Programming
{
    internal class PrimeNumber
    {
        public static bool Prime(int num)
        {
            if (num <= 1) 
               return false;
            if (num == 2) 
               return true;
            if (num % 2 == 0) 
               return false;

            var boundary = (int)Math.Floor(Math.Sqrt(num));

            for (int i = 3; i <= boundary; i += 2)
                if (num % i == 0)
                    return false;

            return true;
        }
    }
}
