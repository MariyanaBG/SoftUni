using System;
using System.Numerics;

namespace _04.CenturiesToMinutes
{
    class Program
    {
        static void Main()
        {
            //Write program to enter an integer number of centuries and convert it to years, days, hours and minutes.

            //    1 centuries = 100 years = 36524 days = 876576 hours = 52594560 minutes
            //    5 centuries = 500 years = 182621 days = 4382904 hours = 262974240 minutes
            //• Use appropriate data type to fit the result after each data conversion.
            //• Assume that a year has 365.2422 days at average(the Tropical year).

            int centuries = int.Parse(Console.ReadLine());
            int years = centuries * 100;
            double days = Math.Floor (years * 365.2422);
            BigInteger hours = (BigInteger)days * 24;
            BigInteger minutes = hours * 60;

            Console.WriteLine($"{centuries} centuries = {years} years = {days} days = {hours} hours = {minutes} minutes");
        }
    }
}
