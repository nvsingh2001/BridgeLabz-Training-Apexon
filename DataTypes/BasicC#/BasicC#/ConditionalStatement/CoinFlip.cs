using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicC_.ConditionalStatement
{
    internal class CoinFlip
    {
        private int flips;
        public void FlipCoin()
        {

            flips = Convert.ToInt32(Console.ReadLine());

            if (flips <= 0)
            {
                Console.WriteLine("Number of flips must be greater than zero.");
                return;
            }

            int numberOfHeads = 0;
            int numberOfTails = 0;

            Random random = new Random();

            for (int i = 0; i < flips; i++)
            {
                double flipResult = random.NextDouble();
                if (flipResult < 0.5)
                    numberOfTails++;
                else
                    numberOfHeads++;
            }

            double percentageOfHeads = (double)numberOfHeads / flips * 100;
            double percentageOfTails = (double)numberOfTails / flips * 100;

            Console.WriteLine($"Percentage of Heads = {percentageOfHeads:F2}%");
            Console.WriteLine($"Percentage of Tails = {percentageOfTails:F2}%");
        }
    }
}
