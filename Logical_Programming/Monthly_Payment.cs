using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logical_Programming
{
    internal class Monthly_Payment
    {
        public static double MonthlyPayment(double U, double V, double W)
        {
            // Number of monthly payments
            double n = 12 * V;

            // Monthly interest rate
            double r = W / (12 * 100);

            // Calculate the monthly payment
            double Payment = (U * r) / (1 - Math.Pow(1 + r, -n));

            return Payment;
        }
    }
}
