using System;

namespace _04.PasswordValidator
{
    class Program
    {
        static void Main(string[] args)
        {
            //Write a program that checks if a given password is valid.Password rules are:
            //    • 6 – 10 characters(inclusive)
            //    • Consists only of letters and digits
            //    • Have at least 2 digits
            //If a password is valid print "Password is valid".If it is not valid, for every unfulfilled rule print a message:
            //    • "Password must be between 6 and 10 characters"
            //    • "Password must consist only of letters and digits"
            //    • "Password must have at least 2 digits"
            //        logIn
            //                        Password must be between 6 and 10 characters
            //                        Password must have at least 2 digits
            //        MyPass123
            //                        Password is valid
            //        Pa$s$s
            //                        Password must consist only of letters and digits
            //                        Password must have at least 2 digits

            string password = Console.ReadLine();
            PrintPasswordValidation(password);
        }

        private static void PrintPasswordValidation(string password)
        {
            bool hasBetween6And10Characters = CheckNumberOfCharacters(password);
            bool consistsOnlyLettersAndDigits = CheckConsistenceOfOnlyLettersAndDigits(password);
            bool hasAtLeastTwoDigits = CheckExistingOfTwoDigits(password);

            if (!hasBetween6And10Characters)
            {
                Console.WriteLine("Password must be between 6 and 10 characters");
            }

            if (!consistsOnlyLettersAndDigits)
            {
                Console.WriteLine("Password must consist only of letters and digits");
            }

            if (!hasAtLeastTwoDigits)
            {
                Console.WriteLine("Password must have at least 2 digits");
            }

            if (hasBetween6And10Characters && consistsOnlyLettersAndDigits && hasAtLeastTwoDigits)
            {
                Console.WriteLine("Password is valid");
            }
        }

        private static bool CheckExistingOfTwoDigits(string password)
        {
            bool result = false;
            int counter = 0;
            for (int i = 0; i < password.Length; i++)
            {
                if (Char.IsDigit(password[i]))
                {
                    counter++;
                    if (counter == 2)
                    {
                        result = true;
                        break;
                    }
                }
            }
            return result;
        }

        private static bool CheckConsistenceOfOnlyLettersAndDigits(string password)
        {
            bool result = true;
            for (int i = 0; i < password.Length; i++)
            {
                if (!(Char.IsDigit(password[i]) || Char.IsLetter(password[i])))
                {
                    result = false;
                    break;
                }
            }
            return result;
        }

        private static bool CheckNumberOfCharacters(string password)
        {
            bool result = false;
            if (password.Length >= 6 && password.Length <= 10)
            {
                result = true;
            }
            return result;
        }
    }
}
