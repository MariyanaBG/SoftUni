using System;

namespace _05.MultiplicationSign
{
    class Program
    {
        static void Main(string[] args)
        {
            //You are given a number num1, num2 and num3. Write a program that finds if num1 * num2 * num3(the product) 
            //is negative, positive or zero.Try to do this WITHOUT multiplying the 3 numbers.
            //        2
            //        3
            //        - 1
            //                negative
            //        2
            //        3
            //        1
            //        positive

            int num1 = int.Parse(Console.ReadLine());
            int num2 = int.Parse(Console.ReadLine());
            int num3 = int.Parse(Console.ReadLine());

            string result = FindProductSign(num1, num2, num3);
            Console.WriteLine(result);
        }

        private static string FindProductSign(int num1, int num2, int num3)
        {
            string result = string.Empty;
            if (num1 == 0 || num2 == 0 || num3 == 0)
            {
                result = "zero";
            }
            else if ((num1 < 0 && num2 > 0 && num3 > 0) ||
                     (num2 < 0 && num1 > 0 && num3 > 0) ||
                     (num3 < 0 && num1 > 0 && num2 > 0) ||
                     (num1 < 0 && num2 < 0 && num3 < 0))
            {
                result = "negative";
            }
            else
            {
                result = "positive";
            }
            return result;
        }
    }
}
