using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logical_Programming
{
    internal class Coupon_Numbers
    {
        public static string GenerateCoupon(int length)
        {
            Random random = new Random();
            const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";
            char[] coupon = new char[length];

            for (int i = 0; i < length; i++)
            {
                coupon[i] = chars[random.Next(chars.Length)];
            }

            return new string(coupon);
        }
    }
}
