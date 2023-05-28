using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logical_Programming
{
    internal class DaysofWeek
    {
        public static int DayWeek(int day, int month, int year)
        {
            int Y = year - (14 - month) / 12;
            int X = Y + Y / 4 - Y / 100 + Y / 400;
            int M = month + 12 * ((14 - month) / 12) - 2;
            int D = (day + X + (31 * M) / 12) % 7;

            return D;
        }
    }
}
