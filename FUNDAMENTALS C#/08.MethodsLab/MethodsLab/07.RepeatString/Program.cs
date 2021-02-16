using System;
using System.Text;

namespace _07.RepeatString
{
    class Program
    {
        static void Main(string[] args)
        {
            //Write a method that receives a string and a repeat count n(integer). 
            //The method should return a new string(the old one repeated n times)
            //    abc
            //    3
            //            abcabcabc
            //    String
            //    2
            //            StringString
            //    Hints
            //        1.Firstly read the string and the repeat count n
            //        2.Then create the method and pass it the variables
            //        3.In the main method, print the result

            string text = Console.ReadLine();
            int count = int.Parse(Console.ReadLine());
            string result = RepeatString(text, count);
            Console.WriteLine(result);
        }

        private static string RepeatString(string text, int count)
        {
            StringBuilder result = new StringBuilder();
            for (int i = 0; i < count; i++)
            {
                result.Append(text);
            }
            return result.ToString();
        }
    }
}
