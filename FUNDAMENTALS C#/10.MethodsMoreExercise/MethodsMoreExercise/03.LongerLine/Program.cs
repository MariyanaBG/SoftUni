using System;

namespace _03.LongerLine
{
    class Program
    {
        static void Main(string[] args)
        {
            //You are given the coordinates of four points in the 2D plane.The first and the second pair of points form two different lines.
            //Print the longer line in format "(X1, Y1)(X2, Y2)" starting with the point that is closer to the center of the coordinate 
            //system(0, 0) (You can reuse the method that you wrote for the previous problem).If the lines are of equal length, print only
            //the first one.

            //    2
            //    4
            //    - 1
            //    2
            //    - 5
            //    - 5
            //    4
            //    - 3
            //            (4, -3)(-5, -5)

            double x1 = double.Parse(Console.ReadLine());
            double y1 = double.Parse(Console.ReadLine());
            double x2 = double.Parse(Console.ReadLine());
            double y2 = double.Parse(Console.ReadLine());
            double x3 = double.Parse(Console.ReadLine());
            double y3 = double.Parse(Console.ReadLine());
            double x4 = double.Parse(Console.ReadLine());
            double y4 = double.Parse(Console.ReadLine());

            double lenghtLine1 = LenghtOfLine(x1, y1, x2, y2);
            double lenghtLine2 = LenghtOfLine(x3, y3, x4, y4);

            if (lenghtLine1 >= lenghtLine2)
            {
                if (FindDistance(x1, y1) <= FindDistance(x2, y2))
                {
                    Console.WriteLine($"({x1}, {y1})({x2}, {y2})");
                }
                else
                {
                    Console.WriteLine($"({x2}, {y2})({x1}, {y1})");
                }
            }
            else
            {
                if (FindDistance(x3, y3) <= FindDistance(x4, y4))
                {
                    Console.WriteLine($"({x3}, {y3})({x4}, {y4})");
                }
                else
                {
                    Console.WriteLine($"({x4}, {y4})({x3}, {y3})");
                }
            }
        }

        private static double LenghtOfLine(double x1, double y1, double x2, double y2)
        {
            double catetA = 0.0;
            double catetB = 0.0;

            if ((x1 < 0 && x2 >= 0) || (x1 >= 0 && x2 < 0))
            {
                catetA = Math.Abs(x1) + Math.Abs(x2);
            }
            else
            {
                catetA = Math.Abs(x1 - x2);
            }

            if ((y1 < 0 && y2 >= 0) || (y1 >= 0 && y2 < 0))
            {
                catetB = Math.Abs(y1) + Math.Abs(y2);
            }
            else
            {
                catetB = Math.Abs(y1 - y2);
            }

            double lenght = Math.Sqrt(Math.Pow(catetA, 2) + Math.Pow(catetB, 2));

            return lenght;

        }

        private static double FindDistance(double x1, double y1)
        {
            double result = Math.Sqrt(Math.Pow(x1, 2) + Math.Pow(y1, 2));
            return result;
        }
    }
}
