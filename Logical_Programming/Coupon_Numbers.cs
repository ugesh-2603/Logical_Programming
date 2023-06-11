using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logical_Programming
{
    internal class Coupon_Numbers
    {

        public static void coupon_number(int n)
        {
            int[] coupons = new int[n];  // Create an array to store coupon numbers
            for (int i = 0; i < n; i++)
            {
                coupons[i] = -1; // Initialize with a non-valid value
            }

            Random random = new Random();
            int distinctCoupons = 0;
            int totalCoupons = 0;

            int Limit = (int)Math.Pow(10, n.ToString().Length); // The line calculates the limit value as 10 raised to the power of the number of digits in variable n.
            

            while (distinctCoupons < n)
            {
                int newCoupon = random.Next(0, Limit); // Generate a new coupon number between 0 and the upper limit
                totalCoupons++;

                if (!Contains(coupons, newCoupon)) // // Check if the new coupon number is already present in the array
                {
                    coupons[distinctCoupons] = newCoupon; // // Store the new coupon number in the array
                    distinctCoupons++;
                }
            }
            Console.WriteLine("Total random numbers needed to generate for all distinct numbers: " + totalCoupons);

        }
        
        static bool Contains(int[] arr, int value)
        {
            foreach (int num in arr)
            {
                if (num == value) // Check if the array contains the specified value
                {
                    return true; // Return true if the value is found
                }
            }
            return false; // Return false if the value is not found
        }
    }
}
