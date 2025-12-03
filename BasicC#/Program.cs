using BasicC_.Arrays;
using BasicC_.ConditionalStatement;
using BasicC_.DataTypes;
using BasicC_.Loops;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicC_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //int[] array = { 8, 5, 6, 8, 9, 4, 1 };
            //int target = 9;
            //Console.Write("[");
            //foreach(List<int> pair in PairSum.AllfindPairSum(array, target))
            //{
            //    Console.Write("{" + $"{pair[0]}" + "," +  $"{pair[1]}" + "}");
            //    Console.Write(",");
            //}
            //Console.Write("]");

            //MissingNumber mn = new MissingNumber();


            //int[] array = { 0, 1, 0, 3, 12 };
            //MoveAllZerosToTheEnd.moveAllZeros(array);

            //foreach(int num in array){
            //    Console.Write(num + " ");
            //}

            //int[] array1 = { 1, 2, 2, 1 };
            //int[] array2 = { 2, 2 };

            //foreach (int num in IntersectionOfTwoArrays.intersection(array1,array2))
            //{
            //    Console.Write(num + " ");
            //}

            int[] array1 = { 1, 3, 5 };
            int[] array2 = { 2, 4, 6 };


            foreach (int num in MergeSortedArrays.merge(array1, array2))
            {
                Console.Write(num + " ");
            }
        }
    }
}
