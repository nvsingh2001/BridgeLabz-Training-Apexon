using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Metadata.W3cXsd2001;
using System.Text;
using System.Threading.Tasks;

namespace BasicC_.Arrays
{
    internal class PairSum
    {
        /*
         * 1. Find All Pairs with a Given Sum
         * Problem: Given an array and a target sum, find all pairs of integers in the array that add up to the target sum.
         * Example:
         * Input: arr = [2, 4, 3, 5, 6], 
         * target = 7
         * Output: [(2, 5), (4, 3)]
         * Explanation: Use a hash map to track the complement (target - current element) and check if it already exists in the array.
         */

        public static List<List<int>> AllfindPairSum(int[] array,int target)
        {
            List<List<int>> pairs = new List<List<int>>();
            Dictionary<int, int> map = new Dictionary<int, int>();

            foreach(int i in array)
            {
                if(!map.ContainsKey(i)) map[i] = 1;
                if (map.ContainsKey(target - i))
                {
                    pairs.Add(new List<int> { i, target - i });
                }
            }
            return pairs;
        } 
    }
}
