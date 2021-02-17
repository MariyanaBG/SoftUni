using System;

namespace _02.CenterPoint
{
    class Program
    {
        static void Main(string[] args)
        {
            //You are given the coordinates of two points on a Cartesian coordinate system - X1, Y1, X2 and Y2.
            //Create a method that prints the point that is closest to the center of the coordinate system(0, 0) 
            //in the format(X, Y). If the points are on a same distance from the center, print only the first one.
            //        2
            //        4
            //        - 1
            //        2
            //                    (-1, 2)

            double x1 = double.Parse(Console.ReadLine());
            double y1 = double.Parse(Console.ReadLine());
            double x2 = double.Parse(Console.ReadLine());
            double y2 = double.Parse(Console.ReadLine());

            if(FindDistance(x1, y1) <= FindDistance(x2,y2))
            {
                Console.WriteLine($"({x1}, {y1})");
            }
            else
            {
                Console.WriteLine($"({x2}, {y2})");
            }
        }

        private static double FindDistance(double x1, double y1)
        {
            double result = Math.Sqrt(Math.Pow(x1,2) + Math.Pow(y1,2));
            return result;
        }
    }

}
