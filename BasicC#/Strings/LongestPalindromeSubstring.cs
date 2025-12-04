using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicC_.Strings
{
    internal class LongestPalindromeSubstring
    {
        // 9.Longest Palindromic Substring: Find the longest substring in a given string that is a palindrome
        public static string longestSubstring(string text) 
        {
            string longestPalindrome = "";

            for (int i = 0; i < text.Length; i++) 
            {
                // Odd length palindromes
                int left = i, right = i;
                while (left >= 0 && right < text.Length && text[left] == text[right]) 
                {
                    if (right - left + 1 > longestPalindrome.Length) 
                    {
                        longestPalindrome = text.Substring(left, right - left + 1);
                    }
                    left--;
                    right++;
                }
                // Even length palindromes
                left = i; 
                right = i + 1;
                while (left >= 0 && right < text.Length && text[left] == text[right]) 
                {
                    if (right - left + 1 > longestPalindrome.Length) 
                    {
                        longestPalindrome = text.Substring(left, right - left + 1);
                    }
                    left--;
                    right++;
                }
            }

            return longestPalindrome;
        }
    }
}
