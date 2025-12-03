using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicC_.Arrays
{
    internal class IntersectionOfTwoArrays
    {
        /*
         * 4. Find the Intersection of Two Arrays
         * Problem: Given two arrays, find their intersection (common elements).
         * Example:Input: arr1 = [1, 2, 2, 1], arr2 = [2, 2]Output: [2, 2]
         * Explanation: Use a hash map to count the occurrences of elements in one array and check for matches in the second array.
         */

        public static List<int> intersection(int[] array1, int[] array2)
        {
            if (array1.Length > array2.Length) return intersection(array2, array1);

            var result = new List<int>();

            Dictionary<int, int> map = new Dictionary<int, int>();

            for (int i = 0; i < array1.Length; i++)
            {
                if (!map.ContainsKey(array1[i])) map[array1[i]] = 1;
                else map[array1[i]]++;
            }

            for (int i = 0; i < array2.Length; i++)
            {
                if (map.ContainsKey(array2[i]) && map[array2[i]] > 0)
                {
                    result.Add(array2[i]);
                    map[array2[i]]--;
                }
            }

            return result;
        }
    }
}
