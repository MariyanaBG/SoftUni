using System;

namespace _06.CalculateRectangleArea
{
    class Program
    {
        static void Main(string[] args)
        {
            //Create a method that calculates and returns the area of a rectangle by given width and height:
            //    3
            //    4
            //        12
            //    6
            //    2
            //        12
            //Hints
            //    1.After reading the input
            //    2.Create a method, but this time instead of typing "static void" before its name, type "static double" 
            //      as this will make it to return a value of type double
            //    3.Invoke the method in the main and save the return value in a new variable

            double width = double.Parse(Console.ReadLine());
            double height = double.Parse(Console.ReadLine());
            double area = GetRectangleArea(width, height);
            Console.WriteLine(area);
        }

        private static double GetRectangleArea(double width, double height)
        {
            return width * height;
        }
    }
}
