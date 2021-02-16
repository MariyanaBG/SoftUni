using System;
using System.Linq;

namespace _05.LongestIncreasingSubsequence
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int[] lenght = new int[numbers.Length];
            for (int i = 0; i < lenght.Length; i++)
            {
                lenght[i] = 1;
            }
            int[] prevIndex = new int[numbers.Length];
            for (int i = 0; i < lenght.Length; i++)
            {
                prevIndex[i] = -1;
            }
            if (numbers.Length > 1)
            {
                for (int i = 0; i < numbers.Length - 1; i++)
                {
                    for (int j = i + 1; j < numbers.Length; j++)
                    {
                        if (numbers[j] > numbers[i])
                        {
                            if (prevIndex[j] == -1)
                            {
                                lenght[j] += 1;
                                prevIndex[j] = i;
                            }
                            else
                            {
                                if (numbers[prevIndex[j]] < numbers[i])
                                {
                                    lenght[j] += 1;
                                    prevIndex[j] = i;
                                }
                            }

                        }
                    }
                }
            }

            int longestSequence = 1;
            int lastIndex = numbers.Length;
            for (int i = 0; i < lenght.Length; i++)
            {
                if (lenght[i] > longestSequence)
                {
                    longestSequence = lenght[i];
                    lastIndex = i;
                }
            }
            int[] result = new int[longestSequence];
            if (result.Length > 1)
            {
                for (int i = result.Length - 1; i >= 0; i--)
                {
                    result[i] = numbers[lastIndex];
                    lastIndex = prevIndex[lastIndex];
                }
            }
            else
            {
                result[0] = numbers[0];
            }

            Console.WriteLine(String.Join(' ', result));
        }
    }
}
