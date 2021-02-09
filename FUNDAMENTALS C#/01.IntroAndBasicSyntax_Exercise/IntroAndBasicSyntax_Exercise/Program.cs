using System;

namespace IntroAndBasicSyntax_Exercise
{
    class Program
    {
        static void Main()
        {
            //• 0 - 2 – baby; 
            //• 3 - 13 – child; 
            //• 14 - 19 – teenager;
            //• 20 - 65 – adult;
            //• >= 66 – elder; 
            //• All the values are inclusive.

            int age = int.Parse(Console.ReadLine());
            string answer = ¨¨;

            if (age >= 0 && age <= 2)
            {
                answer = "baby";¨¨
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
