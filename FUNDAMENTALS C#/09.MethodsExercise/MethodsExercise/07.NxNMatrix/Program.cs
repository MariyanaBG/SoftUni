using System;
using System.Text;

namespace _07.NxNMatrix
{
    class Program
    {
        static void Main(string[] args)
        {
            //Write a method that receives a single integer N and prints NxN matrix with that number.
            //    3
            //                3 3 3
            //                3 3 3
            //                3 3 3
            //    7
            //                7 7 7 7 7 7 7
            //                7 7 7 7 7 7 7
            //                7 7 7 7 7 7 7
            //                7 7 7 7 7 7 7
            //                7 7 7 7 7 7 7
            //                7 7 7 7 7 7 7
            //                7 7 7 7 7 7 7
            //    2
            //                2 2
            //                2 2

            int n = int.Parse(Console.ReadLine());

            PrintMatrixNxN(n);
        }

        private static void PrintMatrixNxN(int n)
        {
            string line = PrintLineFrom1toN(n);
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine(line);
            }
        }

        private static string PrintLineFrom1toN(int n)
        {
            StringBuilder line = new StringBuilder();

            for (int i = 0; i < n; i++)
            {
                line.Append(n + " ");
            }

            return line.ToString();
        }
    }
}
