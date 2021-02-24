using System;
using System.Linq;
using System.Collections.Generic;

namespace _04.MixedUpLists
{
    class Program
    {
        static void Main(string[] args)
        {
            //Write a program that mixes up two lists by some rules.You will receive two lines of input, each one being a list of numbers.
            //The rules for mixing are:
            //    • Start from the beginning of the first list and from the ending of the second.
            //    • Add element from the first and element from the second.
            //    • At the end there will always be a list, in which there are 2 elements remaining.
            //    • These elements will be the range of the elements you need to print.
            //    • Loop through the result list and take only the elements that fulfill the condition.
            //    • Print the elements ordered in ascending order and separated by a space.
            //1 5 23 64 2 3 34 54 12
            //43 23 12 31 54 51 92
            //                        23 23 31 34 43 51
            //Comment
            //After looping through the two of the arrays we get: 
            //1 92 5 51 23 54 64 31 2 12 3 23 34 43
            //The constrains are 54 and 12(so we take only the numbers between them): 51 23 31 23 34 43
            //We print the result sorted

            List<int> first = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            List<int> second = Console.ReadLine().Split(' ').Select(int.Parse).ToList();

            bool firstIsLonger = FindLongerList(first, second);
            List<int> result = new List<int>(first.Count + second.Count);

            if (firstIsLonger)
            {
                result = WhenFirtsIsLonger(first, second);
            }
            else
            {
                result = WhenSecondIsLonger(first, second);
            }

            Console.WriteLine(string.Join(" ", result));
        }

        private static List<int> WhenSecondIsLonger(List<int> first, List<int> second)
        {
            List<int> result = new List<int>(first.Count + second.Count);
            int minValue = Math.Min(second[0], second[1]);
            int maxValue = Math.Max(second[0], second[1]);


            for (int i = 0, j = second.Count - 1; i < first.Count; i++, j--)
            {
                if (first[i] > minValue && first[i] < maxValue)
                {
                    result.Add(first[i]);
                }

                if (second[j] > minValue && second[j] < maxValue)
                {
                    result.Add(second[j]);
                }
            }

            result.Sort();

            return result;
        }

        private static List<int> WhenFirtsIsLonger(List<int> first, List<int> second)
        {
            List<int> result = new List<int>(first.Count + second.Count);
            int minValue = Math.Min(first[first.Count - 2], first[first.Count - 1]);
            int maxValue = Math.Max(first[first.Count - 2], first[first.Count - 1]);


            for (int i = 0, j = second.Count - 1; i < second.Count; i++, j--)
            {
                if (first[i] > minValue && first[i] < maxValue)
                {
                    result.Add(first[i]);
                }

                if (second[j] > minValue && second[j] < maxValue)
                {
                    result.Add(second[j]);
                }
            }

            result.Sort();

            return result;
        }

        private static bool FindLongerList(List<int> first, List<int> second)
        {
            bool isLonger = false;

            if (first.Count > second.Count)
            {
                isLonger = true;
            }
            else
            {
                isLonger = false;
            }

            return isLonger;
        }
    }
}
