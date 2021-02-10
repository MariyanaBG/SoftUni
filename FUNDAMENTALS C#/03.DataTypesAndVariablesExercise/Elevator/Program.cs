using System;

namespace Elevator
{
    class Program
    {
        static void Main(string[] args)
        {
            //Calculate how many courses will be needed to elevate n persons by using an elevator of capacity of p persons.
            //The input holds two lines: the number of people n and the capacity p of the elevator.

            //17  3   ->  6
            //4   5   ->  1
            //10  5   ->  2

            //    • You should divide n by p. This gives you the number of full courses(e.g. 17 / 3 = 5).
            //    • If n does not divide p without a remainder, you will need one additional partially full course(e.g. 17 % 3 = 2).
            //    • Another approach is to round up n / p to the nearest integer(ceiling), e.g. 17 / 3 = 5.67  rounds up to 6.

            int persons = int.Parse(Console.ReadLine());
            int capacity = int.Parse(Console.ReadLine());

            int courses = (int)Math.Ceiling((double)persons / capacity);

            Console.WriteLine(courses);
        }
    }
}
