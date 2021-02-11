using System;
using System.Linq;

namespace _04.ReverseArrayOfStrings
{
    class Program
    {
        static void Main(string[] args)
        {
            //Read an array of strings(space separated values), reverse it and print its elements:
            //    a b c d e
            //    e d c b a
            //    - 1 hi ho w
            //     w ho hi -1

            string[] input = Console.ReadLine().Split(' ');
            Array.Reverse(input);
            Console.WriteLine(String.Join(' ', input));
        }
    }
}
