using System;

namespace _02.Grades
{
    class Program
    {
        static void Main(string[] args)
        {
            //Write a method that receives a grade between 2.00 and 6.00 and prints the corresponding grade in words
            //    • 2.00 – 2.99 - "Fail"
            //    • 3.00 – 3.49 - "Poor"
            //    • 3.50 – 4.49 - "Good"
            //    • 4.50 – 5.49 - "Very good"
            //    • 5.50 – 6.00 - "Excellent"

            double grade = double.Parse(Console.ReadLine());
            PrintGradeInWords(grade);
        }

        private static void PrintGradeInWords(double grade)
        {
            string result = String.Empty;
            if (grade >= 2.00 && grade <= 2.99)
            {
                result = "Fail";
            }
            else if (grade >= 3.00 && grade <= 3.49)
            {
                result = "Poor";
            }
            else if (grade >= 3.50 && grade <= 4.49)
            {
                result = "Good";
            }
            else if (grade >= 4.50 && grade <= 5.49)
            {
                result = "Very good";
            }
            else if (grade >= 5.50 && grade <= 6.00)
            {
                result = "Excellent";
            }
            Console.WriteLine(result);
        }
    }
}
