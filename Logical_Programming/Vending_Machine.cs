using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logical_Programming
{
    internal class Vending_Machine
    {
        static int[] notes = new int[] { 1000, 500, 100, 50, 10, 5, 2, 1 };  // This line declares an array called notes of type int and initializes it with the denominations of currency notes in descending order.

        public static void Ven_mac(int amount)
        {
            CalculateChange(amount);
        }

        public static void CalculateChange(int change) // This is the CalculateChange method that takes a change parameter. 
          
        {
            List<int> result = new List<int>();  //It initializes an empty list called result to store the denominations of notes required. 
            int remaining = change;  // It also initializes an int variable called remaining to keep track of the remaining change to be calculated.

            for (int i = 0; i < notes.Length; i++)
            {
                while (remaining >= notes[i])
                {
                    remaining -= notes[i];
                    result.Add(notes[i]);
                }
            }

            Console.WriteLine($"Minimum number of notes required: {result.Count}");

            Console.WriteLine("The notes are:");
            foreach (int note in result)
            {
                //Console.WriteLine("₹ "+note);
                Console.WriteLine("INR " + note);
            }
        }
    }
}
