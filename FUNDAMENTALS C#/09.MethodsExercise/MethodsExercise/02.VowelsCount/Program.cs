using System;

namespace _02.VowelsCount
{
    class Program
    {
        static void Main(string[] args)
        {
            //Write a method that receives a single string and prints the count of the vowels. Use appropriate name for the method.
            //    SoftUni =>  3
            //    Cats    =>  1
            //    JS      =>  0

            string text = Console.ReadLine();
            PrintTheCountOfVowels(text);
        }

        private static void PrintTheCountOfVowels(string text)
        {
            int counter = 0;
            string vowels = "AaEeIiOoUu";
            for (int i = 0; i < text.Length; i++)
            {
                if (vowels.Contains(text[i]))
                {
                    counter++;
                }
            }
            Console.WriteLine(counter);
        }
    }
}
