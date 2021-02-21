using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _01.Messaging
{
    class Program
    {
        static void Main(string[] args)
        {
            //You will be given a list of numbers and a string.For each element of the list you have to calculate the sum of its digits 
            //and take the element, corresponding to that index from the text. If the index is greater than the length of the text, 
            //start counting from the beginning (so that you always have a valid index). After you get that element from the text, 
            //you must remove the character you have taken from it(so for the next index, the text will be with one character less).
            //    9992 562 8933
            //    This is some message for you
            //                                    hey

            List<int> numbers = Console.ReadLine().Split(" ").Select(int.Parse).ToList();
            string text = Console.ReadLine();

            List<int> indexes = new List<int>(numbers.Count);
            for (int i = 0; i < numbers.Count; i++)
            {
                int currentNumber = numbers[i];
                int sum = 0;

                while (currentNumber > 0)
                {
                    int currentDigit = currentNumber % 10;
                    sum += currentDigit;
                    currentNumber /= 10;
                }

                indexes.Add(sum);
            }

            StringBuilder result = new StringBuilder(indexes.Count);

            for (int i = 0; i < indexes.Count; i++)
            {
                int currentIndex = indexes[i];
                if (currentIndex >= text.Length)
                {
                    currentIndex %= text.Length;
                }
                result.Append(text[currentIndex]);
                text = text.Remove(currentIndex, 1);
            }

            Console.WriteLine(result);
        }
    }
}
