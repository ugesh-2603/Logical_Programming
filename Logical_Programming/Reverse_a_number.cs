using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logical_Programming
{
    internal class Reverse_a_number
    {
        public static int ReverseNumber(int num)
        {
            int reverse = 0;
            while (num > 0)
            {
                int remainder = num % 10;
                reverse = (reverse * 10) + remainder;
                num = num / 10;
            }
            return reverse;
        }
    }
}
