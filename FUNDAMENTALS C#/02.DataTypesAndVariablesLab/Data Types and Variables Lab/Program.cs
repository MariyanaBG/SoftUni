using System;


namespace Data_Types_and_Variables_Lab
{
    class Program
    {
        static void Main()
        {
            //You will be given an integer that will be distance in meters.
            //Write a program that converts meters to kilometers formatted to the second decimal point.

            int number = int.Parse(Console.ReadLine());
            decimal metersToKilometers = number / 1000.0m;

            Console.WriteLine($"{metersToKilometers:F2}");
        }
    }
}
