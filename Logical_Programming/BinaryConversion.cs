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
            string Binary = "";

            while (Number > 0)
            {
                Binary = (Number % 2) + Binary;
                Number = Number / 2;
            }
           
            return Binary;
        }
    }
}
