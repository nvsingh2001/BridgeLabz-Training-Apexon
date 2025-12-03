using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicC_.ConditionalStatement
{
    internal class VowelsOrConsonant
    {
        // C# Program to Check Whether an Alphabet is Vowel or Consonant
        public static void vowelsOrConsonant()
        {
            Console.Write("Enter your alphabet: ");
            char alphabet = Console.ReadKey().KeyChar;

            if(!((alphabet >= 'A' && alphabet <= 'Z') || (alphabet >= 'a' && alphabet <= 'z')))
            {
                Console.WriteLine("\nNot an alphabet");
                return;
            } 

            char lowerCaseAlpha = char.ToLower(alphabet);

            if(lowerCaseAlpha == 'a' || lowerCaseAlpha == 'e' || lowerCaseAlpha == 'i' || lowerCaseAlpha == 'o' || lowerCaseAlpha == 'u')
            {
                Console.WriteLine($"\n{alphabet} is a vowel.");
            }
            else
            {
                Console.WriteLine($"\n{alphabet} is a Consonant");
            }
        }
    }
}
