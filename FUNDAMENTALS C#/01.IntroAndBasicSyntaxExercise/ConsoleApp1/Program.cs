using System;

namespace Age
{
    class Program
    {
        static void Main()
        {
            int age = int.Parse(Console.ReadLine());
            string answer = string.Empty;

            if (age >= 0 && age <= 2)
            {
                answer = "baby";
            }
            else if (age >= 3 && age <= 13)
            {
                answer = "child";
            }
            else if (age >= 14 && age <= 19)
            {
                answer = "teenager";
            }
            else if (age >= 20 && age <= 65)
            {
                answer = "adult";
            }
            else
            {
                answer = "elder";
            }

            Console.WriteLine(answer);
        }
    }
}
