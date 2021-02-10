using System;

namespace Login
{
    class Program
    {
        static void Main()
        {
            //You will be given a string representing a username. 
            //The password will be that username reversed.
            //Until you receive the correct password print on the console “Incorrect password. Try again.”. 
            //When you receive the correct password print “User { username} logged in.” 
            //However on the fourth try if the password is still not correct print “User { username} blocked!” and end the program.

            string username = Console.ReadLine();
            string correctPassword = string.Empty;

            for (int i = username.Length - 1; i >= 0; i--)
            {
                correctPassword += username[i];
            }

            string inputPassword = Console.ReadLine();
            int countAttempts = 0;
            while (inputPassword != correctPassword)
            {
                countAttempts++;
                if (countAttempts == 4)
                {
                    Console.WriteLine($"User {username} blocked!");
                    break;
                }
                else
                {
                    Console.WriteLine("Incorrect password. Try again.");
                }

                inputPassword = Console.ReadLine();
            }

            if (inputPassword == correctPassword)
            {
                Console.WriteLine($"User { username} logged in.");
            }

        }
    }
}
