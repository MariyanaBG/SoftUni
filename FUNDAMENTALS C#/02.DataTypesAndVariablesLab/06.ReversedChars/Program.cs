using System;

namespace _06.ReversedChars
{
    class Program
    {
        static void Main()
        {
            //Write a program that takes 3 lines of characters and prints them in reversed order with a space between them.
            char firstCharacter = char.Parse(Console.ReadLine());
            char secondCharacter = char.Parse(Console.ReadLine());
            char thirdCharacter = char.Parse(Console.ReadLine());

            Console.WriteLine($"{thirdCharacter} {secondCharacter} {firstCharacter}");

        }
    }
}
