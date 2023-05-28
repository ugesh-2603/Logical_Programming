using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logical_Programming
{
    internal class Stop_Watch
    {
        public static void stopwatch()
        {
            Console.WriteLine("Press any key to start the stopwatch...");
            Console.ReadKey();

            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();

            Console.WriteLine("Stopwatch started. Press any key to stop...");
            Console.ReadKey();

            stopwatch.Stop();

            TimeSpan elapsedTime = stopwatch.Elapsed;

            Console.WriteLine("Elapsed Time: {0}", elapsedTime);

            Console.WriteLine("Press any key to exit...");
            Console.ReadKey();
        }
    }
}
