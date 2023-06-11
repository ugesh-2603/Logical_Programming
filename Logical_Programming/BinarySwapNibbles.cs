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
            string binary = BinaryConversion.Binary(n);  // converting 
            while (binary.Length % 8 != 0)  // binary string with zeros to ensure its length is a multiple of 8
            {
                binary = "0" + binary;
            }

            string swappedBinary = "";  // Createing a new string 
            for (int i = 0; i < binary.Length; i += 8)  // // Iterate over the binary string in increments of 8
            {
                swappedBinary += binary.Substring(i + 4, 4) + binary.Substring(i, 4); // The purpose of these lines is to swap the positions of the two nibbles within each 8-bit group in the binary string. By appending the second nibble first and then the first nibble, the positions of the nibbles are effectively swapped.
            }

            return swappedBinary; //  // Return the swapped binary rep
           
        }

        public static string toDeci(string swappedBinary)
        {
            int decimalNum = 0;  // // Initialize a variable to store the decimal value
            for (int i = 0; i < swappedBinary.Length; i++)  // Iterate over each character in the swapped binary string
            {
                if (swappedBinary[i] == '1') // If the current character is '1', update the decimal value
                                             // by adding the corresponding power of 2 based on its position
                {
                    decimalNum += (int)Math.Pow(2, swappedBinary.Length - i - 1);
                }
            }

            
            return Convert.ToString(decimalNum); // Convert the decimal value to a string and return it
        }
    }
}
