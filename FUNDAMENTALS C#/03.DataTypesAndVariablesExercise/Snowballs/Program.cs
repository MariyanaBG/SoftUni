using System;
using System.Numerics;

namespace Snowballs
{
    class Program
    {
        static void Main(string[] args)
        {
            //Tony and Andi love playing in the snow and having snowball fights, but they always argue which makes the best snowballs. 
            //They have decided to involve you in their fray, by making you write a program, which calculates snowball data, 
            //and outputs the best snowball value.

            //You will receive N – an integerin range[0, 100] , the number of snowballs being made by Tony and Andi.
            //For each snowball you will receive 3 input lines:
            //    • On the first line you will get the snowballSnow – an integer in range[0, 1000].
            //    • On the second line you will get the snowballTime – an integer in range[1, 500].
            //    • On the third line you will get the snowballQuality – an integer in range[0, 100].

            //For each snowball you must calculate its snowballValue by the following formula:
            //(snowballSnow / snowballTime) ^ snowballQuality
            //At the end you must print the highest calculated snowballValue.
            //{ snowballSnow} : { snowballTime} = { snowballValue} ({ snowballQuality})

            int numberOfSnowballs = int.Parse(Console.ReadLine());

            int bestSnowballSnow = 0;
            int bestSnowballTime = 0;
            int bestSnowballQuality = 0;
            BigInteger bestSnowballValue = 0;

            if (numberOfSnowballs != 0)
            {
                for (int i = 0; i < numberOfSnowballs; i++)
                {
                    int snowballSnow = int.Parse(Console.ReadLine()); // 0 1000
                    int snowballTime = int.Parse(Console.ReadLine()); // 1 500
                    int snowballQuality = int.Parse(Console.ReadLine()); // 0 100

                    BigInteger snowballValue = BigInteger.Pow(snowballSnow / snowballTime, snowballQuality);
                    if (snowballValue > bestSnowballValue)
                    {
                        bestSnowballValue = snowballValue;
                        bestSnowballSnow = snowballSnow;
                        bestSnowballTime = snowballTime;
                        bestSnowballQuality = snowballQuality;
                    }
                }
            }
            Console.WriteLine($"{bestSnowballSnow} : {bestSnowballTime} = {bestSnowballValue} ({bestSnowballQuality})");
        }
    }
}
