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
            int[] coupons = new int[n];
            for (int i = 0; i < n; i++)
            {
                coupons[i] = -1; // Initialize with a non-valid value
            }

            Random random = new Random();
            int distinctCoupons = 0;
            int totalCoupons = 0;

            int Limit = (int)Math.Pow(10, n.ToString().Length);
            // This part of the code will allow our code to have Flexible Range.

            while (distinctCoupons < n)
            {
                int newCoupon = random.Next(0, Limit); // Generate new coupon number
                totalCoupons++;

                if (!Contains(coupons, newCoupon))
                {
                    coupons[distinctCoupons] = newCoupon;
                    distinctCoupons++;
                }
            }
            Console.WriteLine("Total random numbers needed to generate for all distinct numbers: " + totalCoupons);

        }
        
        static bool Contains(int[] arr, int value)
        {
            foreach (int num in arr)
            {
                if (num == value)
                {
                    return true;
                }
            }
            return false;
        }
    }
}
