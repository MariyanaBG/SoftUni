using System;
using System.Linq;
using System.Collections.Generic;

namespace _05.BombNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            //Write a program that reads a sequence of numbers and a special bomb number with a certain power. 
            //Your task is to detonate every occurrence of the special bomb number and according to its power 
            //-his neighbors from left and right.Detonations are performed from left to right and all detonated numbers disappear. 
            //Finally print the sum of the remaining elements in the sequence.
            //    1 2 2 4 2 2 2 9
            //    4 2
            //                            12
            //                                    Special number is 4 with power 2.
            //                                    After detontaion we are left with the sequence[1, 2, 9] with sum 12.
            //    1 4 4 2 8 9 1
            //    9 3
            //                            5
            //                                    Special number is 9 with power 3.
            //                                    After detontaion we are left with the sequence[1, 4] with sum 5.
            //                                    Since the 9 has only 1 neighbour from the right we remove just it(one number instead of 3).
            //      1 7 7 1 2 3
            //      7 1
            //                            6
            //                                    Detonations are performed from left to right.We cannot detonate the second occurance of 7,
            //                                    because its already destroyed by the first occurance. The numbers[1, 2, 3] survive.
            //                                    Their sum is 6.
            //      1 1 2 1 1 1 2 1 1 1
            //      2 1
            //                            4
            //                                    The red and yellow numbers disappear in two sequential detonations.
            //                                    The result is the sequence [1, 1, 1, 1]. Sum = 4.

            List<int> numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            int[] commands = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int bombNumber = commands[0];
            int power = commands[1];

            int bombNumberIndex = numbers.IndexOf(bombNumber);

            while (bombNumberIndex != -1)
            {
                int startIndex = 0;
                if (bombNumberIndex - power < 0)
                {
                    startIndex = 0;
                }
                else
                {
                    startIndex = bombNumberIndex - power;
                }

                int endIndex = 0;
                if (bombNumberIndex + power >= numbers.Count)
                {
                    endIndex = numbers.Count - 1;
                }
                else
                {
                    endIndex = bombNumberIndex + power;
                }

                int count = endIndex - startIndex + 1;

                numbers.RemoveRange(startIndex, count);

                bombNumberIndex = numbers.IndexOf(bombNumber);
            }

            Console.WriteLine(numbers.Sum());
        }
    }
}
