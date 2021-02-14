using System;
using System.Linq;

namespace _07.MaxSequenceOfEqualElements
{
    class Program
    {
        static void Main(string[] args)
        {
            //Write a program that finds the longest sequence of equal elements in an array of integers. 
            //If several longest sequences exist, print the leftmost one.
            //    2 1 1 2 3 3 2 2 2 1 =>  2 2 2
            //    1 1 1 2 3 1 3 3     =>  1 1 1
            //    4 4 4 4             =>  4 4 4 4
            //    0 1 1 5 2 2 6 3 3   =>  1 1

            int[] numbers = Console.ReadLine().Split(' ')
                                              .Select(int.Parse)
                                              .ToArray();
            int longestSequenceElement = 0;
            int longestSequenceLenght = 1;

            for (int i = 0; i < numbers.Length - 1; i++)
            {
                int currentElement = numbers[i];
                int currentSequenceLenght = 1;
                for (int j = i + 1; j < numbers.Length; j++)
                {
                    if (currentElement == numbers[j])
                    {
                        currentSequenceLenght++;
                    }
                    else
                    {
                        break;
                    }
                }
                if (currentSequenceLenght > longestSequenceLenght)
                {
                    longestSequenceLenght = currentSequenceLenght;
                    longestSequenceElement = currentElement;
                }
            }
            for (int k = 0; k < longestSequenceLenght; k++)
            {
                Console.Write(longestSequenceElement + " ");
            }

        }
    }
}
