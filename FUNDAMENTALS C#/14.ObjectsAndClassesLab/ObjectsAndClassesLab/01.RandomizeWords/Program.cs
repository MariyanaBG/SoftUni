using System;

namespace _01.RandomizeWords
{
    class Program
    {
        static void Main(string[] args)
        {
            //You are given a list of words in one line. Randomize their order and print each word at a separate line.
            //    Welcome to SoftUni and have fun learning programming
            //                                                                learning
            //                                                                Welcome
            //                                                                SoftUni
            //                                                                and
            //                                                                fun
            //                                                                programming
            //                                                                have
            //                                                                to
            //The order of the words in the output will be different after each program execution.
            //Hints
            //    • Split the input string by(space) and create an array of words.
            //    • Create a random number generator – an object rnd of type Random.
            //    • In a for-loop exchange each number at positions 0, 1, … words.Length - 1 by a number at random position.
            //      To generate a random number in range use rnd.Next(minValue, maxValue).Note that by definition minValue is inclusive, 
            //      but maxValue is exclusive.
            //    • Print each word in the array on new line.

            string[] words = Console.ReadLine().Split(' ');

            Random rnd = new Random();

            for (int i = 0; i < words.Length; i++)
            {
                int j = rnd.Next(0, words.Length);

                if (j != i)
                {
                    string old = words[i];
                    words[i] = words[j];
                    words[j] = old;
                }
            }

            foreach (string word in words)
            {
                Console.WriteLine(word);
            }
        }
    }
}
