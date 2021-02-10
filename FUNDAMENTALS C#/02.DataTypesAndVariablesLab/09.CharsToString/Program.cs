using System;

namespace _09.CharsToString
{
    class Program
    {
        static void Main()
        {
            //Write a program that reads 3 lines of input.
            //On each line you get a single character. 
            //Combine all the characters into one string and print it on the console.

            char firstCharacter = char.Parse(Console.ReadLine());
            char secondCharacter = char.Parse(Console.ReadLine());
            char thirdCharacter = char.Parse(Console.ReadLine());

            string combinedText = firstCharacter.ToString() + secondCharacter.ToString() + thirdCharacter.ToString();

            Console.WriteLine(combinedText);

        }
    }
}
