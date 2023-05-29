using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logical_Programming
{
    internal class BinarySwapNibbles
    {
        public static string swapNibbles(int n)
        {
            string binary = BinaryConversion.Binary(n);
            while (binary.Length % 8 != 0)
            {
                binary = "0" + binary;
            }

            string swappedBinary = "";
            for (int i = 0; i < binary.Length; i += 8)
            {
                swappedBinary += binary.Substring(i + 4, 4) + binary.Substring(i, 4);
            }

            return swappedBinary;
           
        }

        public static string toDeci(string swappedBinary)
        {
            int decimalNum = 0;
            for (int i = 0; i < swappedBinary.Length; i++)
            {
                if (swappedBinary[i] == '1')
                {
                    decimalNum += (int)Math.Pow(2, swappedBinary.Length - i - 1);
                }
            }

            
            return Convert.ToString(decimalNum);
        }
    }
}
