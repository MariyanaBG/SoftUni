﻿using System;

namespace _07.ConcatNames
{
    class Program
    {
        static void Main()
        {
            //Read two names and a delimiter. Print the names joined by the delimiter.

            string firstName = Console.ReadLine();
            string secondName = Console.ReadLine();
            string delimiter = Console.ReadLine();

            Console.WriteLine($"{firstName}{delimiter}{secondName}");

        }
    }
}