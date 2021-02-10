using System;

namespace _11.RefactorVolumeOfPyramid
{
    class Program
    {
        static void Main()
        {
            //You are given a working code that finds the volume of a pyramid.However, 
            //you should consider that the variables exceed their optimum span and have improper naming. 
            //Also, search for variables that have multiple purpose.
            //    • Reduce the span of the variables by declaring them in the moment they receive a value, not before
            //    • Rename your variables to represent their real purpose(example: "dul" should become length, etc.)
            //    • Search for variables that have multiple purpose.If you find any, introduce a new variable.

            double lenght = double.Parse(Console.ReadLine());
            double width = double.Parse(Console.ReadLine());
            double height = double.Parse(Console.ReadLine());
            double volume = (lenght * width * height) / 3;

            Console.Write("Length: ");
            Console.Write("Width: ");
            Console.Write("Height: ");
            Console.WriteLine($"Pyramid Volume: {volume:f2}");
        }
    }
}
