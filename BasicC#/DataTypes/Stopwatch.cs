using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace BasicC_.Loops
{
    internal class Stopwatch
    {
        public static void stopwatch()
        {
            DateTime start = default;
            DateTime stop = default;
            Console.WriteLine("Press Enter to start...");
            var key = Console.ReadKey();
            if (key.Key == ConsoleKey.Enter)
            {
                start = DateTime.Now;
            }
            Console.WriteLine("Press Enter to stop...");
            key = Console.ReadKey();
            if (key.Key == ConsoleKey.Enter)
            {
                stop = DateTime.Now;
            }
            TimeSpan elapsed = stop - start;
            Console.WriteLine($"{elapsed.Hours}:{elapsed.Minutes}:{elapsed.Seconds}");
        }
    }
}
