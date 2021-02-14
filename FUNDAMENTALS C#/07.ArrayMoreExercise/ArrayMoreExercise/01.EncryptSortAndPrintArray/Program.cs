using System;

namespace _01.EncryptSortAndPrintArray
{
    class Program
    {
        static void Main(string[] args)
        {
            //Write a program that reads a sequence of strings from the console. Encrypt every string by summing:
            //    • The code of each vowel multiplied by the string length
            //    • The code of each consonant divided by the string length
            //Sort the number sequence in ascending order and print it on the console.
            //On first line, you will always receive the number of strings you have to read.

            int n = int.Parse(Console.ReadLine());
            int[] numbers = new int[n];

            for (int i = 0; i < n; i++)
            {
                int sum = 0;
                string word = Console.ReadLine();
                string vowels = "AaEeIiOoUu";
                for (int j = 0; j < word.Length; j++)
                {
                    if (vowels.Contains(word[j]))
                    {
                        sum += (int)word[j] * word.Length;
                    }
                    else
                    {
                        sum += (int)word[j] / word.Length;
                    }
                }
                numbers[i] = sum;

            }
            Array.Sort(numbers);
            foreach (int number in numbers)
            {
                Console.WriteLine(number);
            }

        }
    }
}
