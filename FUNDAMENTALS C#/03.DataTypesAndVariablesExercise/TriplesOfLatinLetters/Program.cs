using System;

namespace TriplesOfLatinLetters
{
    class Program
    {
        static void Main(string[] args)
        {
            //Write a program to read an integer n and print all triples of the first n small Latin letters, ordered alphabetically:

            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    for (int k = 0; k < n; k++)
                    {
                        char firstLetter = (char)(97 + i);
                        char secondLetter = (char)(97 + j);
                        char thirdLetter = (char)(97 + k);
                        Console.WriteLine($"{firstLetter}{secondLetter}{thirdLetter}");
                    }
                }
            }
        }
    }
}
