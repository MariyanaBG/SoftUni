using System;

namespace _02.PoundsToDollars
{
    class Program
    {
        static void Main()
        {
            //Write a program that converts British pounds to US dollars formatted to 3th decimal point.
            //1 British Pound = 1.31 Dollars

            decimal pounds = decimal.Parse(Console.ReadLine());
            decimal dollars = pounds * 1.31m;

            Console.WriteLine($"{dollars:F3}");
        }
    }
}
