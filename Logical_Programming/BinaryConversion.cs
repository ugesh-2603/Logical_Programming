using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logical_Programming
{
    internal class BinaryConversion
    {
        public static string Binary(int Number)
        {
            string Binary = "";  // empty string

            while (Number > 0)
            {
                Binary = (Number % 2) + Binary;  // number %2 concatenate with the current value of binary
                Number = Number / 2;  // number is dividing by 2
            }
           
            return Binary;  // binary is returned as the result of the method
        }
    }
}
