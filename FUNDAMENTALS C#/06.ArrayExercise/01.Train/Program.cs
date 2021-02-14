using System;
using System.Linq;

namespace _01.Train
{
    class Program
    {
        static void Main(string[] args)
        {
            //You will be given a count of wagons in a train n.On the next n lines you will receive how many people are going to get on each wagon. At the end print the whole train and after that, on the next line, the sum of the people in the train. 
            //    3
            //    13
            //    24
            //    8
            //        13 24 8
            //        45
            //    6
            //    3
            //    52
            //    71
            //    13
            //    65
            //    4
            //        3 52 71 13 65 4
            //        208
            //    1
            //    100
            //        100
            //        100

            int n = int.Parse(Console.ReadLine());
            int[] people = new int[n];
            for (int i = 0; i < n; i++)
            {
                people[i] = int.Parse(Console.ReadLine());
            }

            foreach (int number in people)
            {
                Console.Write(number + " ");
            }
            Console.WriteLine();
            Console.WriteLine(people.Sum());
        }
    }
}
