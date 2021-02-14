using System;
using System.Linq;

namespace _09.KaminoFactory
{
    class Program
    {
        static void Main(string[] args)
        {
            //You will receive the DNA length and until you receive the command "Clone them!" you will be receiving a DNA sequences 
            //of ones and zeroes, split by "!"(one or several).
            //You should select the sequence with the longest subsequence of ones.
            //If there are several sequences with same length of subsequence of ones, print the one with the leftmost starting index,
            //if there are several sequences with same length and starting index, select the sequence with the greater sum of its elements.
            //After you receive the last command "Clone them!" you should print the collected information in the following format:
            //"Best DNA sample {bestSequenceIndex} with sum: {bestSequenceSum}."
            //"{DNA sequence, joined by space}"

            //5
            //1!0!1!1!0
            //0!1!1!0!0
            //Clone them!
            //                    Best DNA sample 2 with sum: 2.
            //                    0 1 1 0 0
            //4
            //1!1!0!1
            //1!0!0!1
            //1!1!0!0
            //Clone them!
            //                    Best DNA sample 1 with sum: 3.
            //                    1 1 0 1

            int n = int.Parse(Console.ReadLine());

            int[] bestDNA = new int[n];
            int bestIndex = n;
            int bestSampleSequenseLenght = 0;
            int bestSum = 0;
            int bestSample = 1;

            string input = Console.ReadLine();
            int currentSample = 0;

            while (input != "Clone them!")
            {
                int[] currentDNA = input.Split("!".ToCharArray(), StringSplitOptions.RemoveEmptyEntries)
                    .Select(int.Parse)
                    .ToArray();

                currentSample++;

                int currentSequenceLenght = 0;
                int previousSequenceLenght = 0;
                int currentLongestSequence = 0;

                int leftmostIndexInCurrentArray = n;

                int currentSampleSum = 0;

                for (int i = 0; i < currentDNA.Length; i++)
                {
                    if (currentDNA[i] == 1)
                    {
                        currentSequenceLenght++;
                        currentSampleSum++;
                    }
                    else
                    {
                        previousSequenceLenght = currentSequenceLenght;
                        currentSequenceLenght = 0;
                    }

                    if (currentSequenceLenght > previousSequenceLenght)
                    {
                        currentLongestSequence = currentSequenceLenght;
                        leftmostIndexInCurrentArray = i - currentSequenceLenght + 1;
                    }
                }

                if (currentLongestSequence > bestSampleSequenseLenght)
                {
                    bestSampleSequenseLenght = currentLongestSequence;
                    bestIndex = leftmostIndexInCurrentArray;
                    bestDNA = currentDNA;
                    bestSample = currentSample;
                    bestSum = currentSampleSum;
                }
                else if (currentLongestSequence == bestSampleSequenseLenght)
                {
                    if (leftmostIndexInCurrentArray < bestIndex)
                    {
                        bestIndex = leftmostIndexInCurrentArray;
                        bestSum = currentSampleSum;
                        bestDNA = currentDNA;
                        bestSample = currentSample;
                    }
                    else if (bestIndex == leftmostIndexInCurrentArray)
                    {
                        if (currentSampleSum > bestSum)
                        {
                            bestSum = currentSampleSum;
                            bestDNA = currentDNA;
                            bestSample = currentSample;
                        }
                    }
                }

                input = Console.ReadLine();
            }

            Console.WriteLine($"Best DNA sample {bestSample} with sum: {bestSum}.");
            Console.WriteLine(string.Join(" ", bestDNA));
        }
    }
}
