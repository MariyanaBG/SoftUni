using System;

namespace _09.PalindromeIntegers
{
    class Program
    {
        static void Main(string[] args)
        {
            //A palindrome is a number which reads the same backward as forward, such as 323 or 1001.
            //Write a program which reads a positive integer numbers until you receive "End", 
            //for each number print whether the number is palindrome or not.
            //123
            //323
            //421
            //121
            //END
            //        false
            //        true
            //        false
            //        true
            //32
            //2
            //232
            //1010
            //END
            //        false
            //        true
            //        true
            //        false

            string input = Console.ReadLine();

            while (input != "END")
            {
                string isPalindrome = CheckSymetrialNumber(input);
                Console.WriteLine(isPalindrome);

                input = Console.ReadLine();
            }
        }

        private static string CheckSymetrialNumber(string input)
        {
            string result = "true";
            for (int i = 0; i < input.Length / 2; i++)
            {
                if (input[i] != input[input.Length - 1 - i])
                {
                    result = "false";
                    break;
                }
            }
            return result;
        }
    }
}
