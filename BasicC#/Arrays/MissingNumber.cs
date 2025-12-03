using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicC_.Arrays
{
    internal class MissingNumber
    {
        public static void missingNumber(int[] array)
        {
            int length = array.Length;
            int n = array[length - 1];

            int sumOfNnumbers = (n * (n + 1)) / 2;

            int sumOfElementsOfArray = 0;

            for (int i = 0; i < length; i++)
            {
                sumOfElementsOfArray += array[i];
            }

            Console.WriteLine($"Missing Number = {sumOfNnumbers - sumOfElementsOfArray}");
        }

        public MissingNumber(){
            int[] array = { 1, 2, 3, 4, 5, 6, 7, 9, 10};
            missingNumber(array);
        }
    }
}
