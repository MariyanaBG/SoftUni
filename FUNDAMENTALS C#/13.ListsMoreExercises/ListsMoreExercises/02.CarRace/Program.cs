using System;
using System.Linq;
using System.Collections.Generic;

namespace _02.CarRace
{
    class Program
    {
        static void Main(string[] args)
        {
            //Write a program to calculate the winner of a car race.You will receive an array of numbers.Each element of the array 
            //represents the time needed to pass through that step(the index). There are going to be two cars.One of them starts 
            //from the left side and the other one starts from the right side.The middle index of the array is the finish line.
            //The number of elements in the array will always be odd. Calculate the total time for each racer to reach the finish, 
            //which is the middle of the array, and print the winner with his total time(the racer with less time).
            //If you have a zero in the array, you have to reduce the time of the racer that reached it by 20 % (from his current time).
            //Print the result in the following format "The winner is {left/right} with total time: {total time}".
            //    29 13 9 0 13 0 21 0 14 82 12
            //                                    The winner is left with total time: 53.8
            //                                    Comment
            //                                    The time of the left racer is (29 + 13 + 9) * 0.8 (because of the zero) + 13 = 53.8
            //                                    The time of the right racer is (82 + 12 + 14) * 0.8 + 21 = 107.4
            //                                    The winner is the left racer, so we print it

            List<decimal> numbers = Console.ReadLine().Split(' ').Select(decimal.Parse).ToList();

            decimal leftTime = CalculateLeftfTime(numbers);
            decimal rightTime = CalculateRightTime(numbers);
            CompareTimesAndPrint(leftTime, rightTime);
        }

        private static void CompareTimesAndPrint(decimal leftTime, decimal rightTime)

        {
            string winner = string.Empty;
            decimal totalTime = 0;

            if (leftTime <= rightTime)
            {
                winner = "left";
                totalTime = leftTime;

            }
            else
            {
                winner = "right";
                totalTime = rightTime;
            }
            Console.WriteLine($"The winner is {winner} with total time: {totalTime}");
        }

        private static decimal CalculateRightTime(List<decimal > numbers)
        {
            decimal rightTime = 0;
            for (int i = numbers.Count - 1; i >= numbers.Count / 2 + 1; i--)
            {
                if (numbers[i] == 0)
                {
                    rightTime *= 0.8m;
                }
                else
                {
                    rightTime += numbers[i];
                }
            }
            return rightTime;
        }

        private static decimal CalculateLeftfTime(List<decimal > numbers)
        {
            decimal leftTime = 0;
            for (int i = 0; i <= numbers.Count / 2 - 1; i++)
            {
                if (numbers[i] == 0)
                {
                    leftTime *= 0.8m;
                }
                else
                {
                    leftTime += numbers[i];
                }
            }
            return leftTime;
        }
    }
}
