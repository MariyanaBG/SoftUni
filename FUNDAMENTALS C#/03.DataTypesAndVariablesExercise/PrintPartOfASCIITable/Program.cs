﻿using System;

namespace PrintPartOfASCIITable
{
    class Program
    {
        static void Main(string[] args)
        {
            //Find online more information about ASCII(American Standard Code for Information Interchange) 
            //and write a program that prints part of the ASCII table of characters at the console.  
            //On the first line of input you will receive the char index you should start with and on the second line - 
            //the index of the last character you should print.

            int startIndex = int.Parse(Console.ReadLine());
            int endIndex = int.Parse(Console.ReadLine());

            for (int i = startIndex; i <= endIndex; i++)
            {
                Console.Write($"{(char)i} ");
            }

        }
    }
}
