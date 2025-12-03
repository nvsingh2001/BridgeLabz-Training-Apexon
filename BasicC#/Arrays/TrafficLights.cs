using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace BasicC_.ConditionalStatement
{
    internal class TrafficLights
    {
        /*
         * 9 Create a C# program that simulates a traffic light. 
         * Implement a system where the light changes based on predefined time intervals. 
         * Use conditional statements to determine which color (Red, Yellow, Green) should be displayed at any given time.
         */

        public static void trafficLights()
        {
            while (true)
            {
                Console.WriteLine("Red");
                Thread.Sleep(2000);
                Console.WriteLine("Yellow");
                Thread.Sleep(2000);
                Console.WriteLine("Green");
                Thread.Sleep(2000);
            }
        }
    }
}
