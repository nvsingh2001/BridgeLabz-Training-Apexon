using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicC_.ConditionalStatement
{
    internal class Grades
    {
        /*
         * 1. Write a C# program that takes a student's score as input and classifies it into grades (A, B, C, D, or F) based on the following criteria:

            A: 90-100

            B: 80-89

            C: 70-79

            D: 60-69

            F: 0-59
         */
        public static void classifyGrade()
        {
            Console.Write("Enter your score: ");
            int score = int.Parse(Console.ReadLine());

            char grade;

            if(score >= 90)
            {
                grade = 'A';
            }else if (score >= 80)
            {
                grade = 'B';
            } else if(score >= 70)
            {
                grade = 'C';

            }else if(score >= 60)
            {
                grade = 'D';
            }
            else
            {
                grade = 'F';
            }

            Console.WriteLine($"Your grade is {grade}");
        }
    }
}
