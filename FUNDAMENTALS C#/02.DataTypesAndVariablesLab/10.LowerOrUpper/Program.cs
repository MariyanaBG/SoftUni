using System;

namespace _10.LowerOrUpper
{
    class Program
    {
        static void Main()
        {
            //Write a program that prints whether a given character is upper -case or lower case.

            char character = char.Parse(Console.ReadLine());

            if (char.IsLower(character) == true)
            {
                Console.WriteLine("lower-case");
            }
            else
            {
                Console.WriteLine("upper-case");
            }

        }
    }
}
