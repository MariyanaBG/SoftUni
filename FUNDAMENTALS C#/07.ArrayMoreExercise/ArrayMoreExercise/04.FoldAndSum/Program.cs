using System;
using System.Linq;

namespace _04.FoldAndSum
{
    class Program
    {
        static void Main(string[] args)
        {
            //Read an array of 4 * k integers, fold it like shown below, and print the sum of the upper and lower two rows
            //(each holding 2 * k integers):
            //5 2 3 6
            //                                    7 9
            //                                                            5  6 +
            //                                                            2  3 =
            //                                                            7  9
            //1 2 3 4 5 6 7 8
            //                                    5 5 13 13
            //                                                            2  1  8  7 +
            //                                                            3  4  5  6 =
            //                                                            5  5 13 13
            //4 3 - 1 2 5 0 1 9 8 6 7 - 2
            //                                    1 8 4 - 1 16 14
            //                                                     - 1  3  4 - 2  7  6 +
            //                                                        2  5  0  1  9  8 =
            //                                                        1  8  4 - 1 16 14

            int[] numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int[] firstRow = new int[numbers.Length / 2];
            int[] secondRow = new int[numbers.Length / 2];

            for (int i = 0, j = numbers.Length / 4 - 1; i < numbers.Length / 4 && j >= 0; i++, j--)
            {
                firstRow[i] = numbers[j];
            }

            for (int i = numbers.Length / 4, j = numbers.Length - 1; i < firstRow.Length && j >= 0; i++, j--)
            {
                firstRow[i] = numbers[j];
            }

            for (int k = 0, l = numbers.Length / 4; k < secondRow.Length; k++, l++)
            {
                secondRow[k] = numbers[l];
            }

            int[] result = new int[firstRow.Length];
            for (int m = 0; m < result.Length; m++)
            {
                result[m] = firstRow[m] + secondRow[m];
            }
            Console.WriteLine(String.Join(' ', result));
        }
    }
}
