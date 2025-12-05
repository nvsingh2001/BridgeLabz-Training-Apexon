using BasicC_.Arrays;
using BasicC_.ConditionalStatement;
using BasicC_.DataTypes;
using BasicC_.Loops;
using BasicC_.Strings;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
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

            //int[] array1 = { 1, 3, 5 };
            //int[] array2 = { 2, 4, 6 };


            //foreach (int num in MergeSortedArrays.merge(array1, array2))
            //{
            //    Console.Write(num + " ");
            //}

            //int[][] grid = { new int[]{ 1, 2, 3 }, new int[]{ 4, 5, 6 }, new int[]{ 7, 8, 9 } };

            //int[,] shiftedGrid = Shift2DGrid.ShiftGrid(grid, 1);

            //for(int i = 0;i < grid.Length;i++)
            //{
            //    for (int j = 0; j < grid[0].Length; j++)
            //    {
            //        Console.Write(shiftedGrid[i,j] + " ");
            //    }
            //    Console.Write('\n');
            //}

            //Console.WriteLine(PalindromeCheck.check("naman"));

            //Console.WriteLine(AnagramCheck.anagramCheck("eat", "get"));

            //Console.WriteLine(LongestSubstringWithoutRepeatation.LongestSubstring("Check"));

            //Console.WriteLine(CompressString.compressString("aaabbbcccaaaccrr"));

            //Console.WriteLine(NonRepeatingCharacter.nonReapeatingCharacter("Namanm"));

            //Console.WriteLine(RotationOfString.isRotated("naman", "manna"));

            //Console.WriteLine(LongestPalindromeSubstring.longestSubstring("babad"));

            //int[,] matrix = { { 100, 99, 98, 97}, { 93, 94, 95, 96 }, { 92, 91, 90, 89 }, { 85, 86, 87, 88 } };

            //PrintMatrix.Print(matrix);

            //RotateMatrixClockWise.rotateMatrix(matrix);

            //Console.WriteLine();

            //PrintMatrix.Print(matrix);

            //int[,] matrix = { { 1, 2, 3, 4 }, { 5, 6, 7, 8 }, { 9, 10, 11, 12 } };

            //PrintMatrix.Print(matrix);

            //Console.WriteLine();

            //int[,] rotatedMatrix = RotateMatrixBy90Degree.RotateMatrix(matrix);

            //PrintMatrix.Print(rotatedMatrix);

            int[,] matrix = { { 1, 2, 3, 4}, { 5, 6, 7, 8 }, { 9, 10, 11, 12 } , { 13, 14, 15, 16 } };

            MatrixSpiralForm.PrintSpiralForm(matrix);
            
        }
    }
}
