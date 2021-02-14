using System;
using System.Linq;

namespace _03.ZigZagArrays
{
    class Program
    {
        static void Main(string[] args)
        {
            //Write a program which creates 2 arrays.You will be given an integer n.On the next n lines you get 2 integers.
            //Form 2 arrays as shown below.
            //    4
            //    1 5
            //    9 10
            //    31 81
            //    41 20
            //            1 10 31 20
            //            5 9 81 41
            //    2
            //    80 23
            //    31 19
            //            80 19
            //            23 31
            int n = int.Parse(Console.ReadLine());
            string[] array1 = new string[n];
            string[] array2 = new string[n];

            string[] currentArray = new string[2];
            for (int i = 0; i < n; i++)
            {
                if (i % 2 == 0)
                {
                    currentArray = Console.ReadLine().Split(' ');
                    array1[i] = currentArray[0];
                    array2[i] = currentArray[1];
                }
                else
                {
                    currentArray = Console.ReadLine().Split(' ');
                    array1[i] = currentArray[1];
                    array2[i] = currentArray[0];
                }
            }
            Console.WriteLine(String.Join(' ', array1));
            Console.WriteLine(String.Join(' ', array2));

        }
    }
}
