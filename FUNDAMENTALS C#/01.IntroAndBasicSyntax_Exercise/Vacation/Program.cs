using System;

namespace Vacation
{
    class Program
    {
        static void Main()
        {
            //            Friday  SaturdaySunday

            //Students    8.45    9.80    10.46
            //Business    10.90   15.60   16
            //Regular     15      20      22.50

            //• Students – if the group is bigger than or equal to 30 people you should reduce the total price by 15 %
            //• Business – if the group is bigger than or equal to  100 people 10 of them can stay for free.
            //• Regular – if the group is bigger than or equal to 10 and less than or equal to 20 reduce the total price by 5 %

            int groupOfPeople = int.Parse(Console.ReadLine());
            string typeOfTheGroup = Console.ReadLine();
            string dayOfTheWeek = Console.ReadLine();

            decimal totalPrice = 0.0m;

            switch (typeOfTheGroup)
            {
                case "Students":
                    switch (dayOfTheWeek)
                    {
                        case "Friday":
                            totalPrice = groupOfPeople * 8.45m;
                            break;
                        case "Saturday":
                            totalPrice = groupOfPeople * 9.80m;
                            break;
                        case "Sunday":
                            totalPrice = groupOfPeople * 10.46m;
                            break;
                    }
                    if (groupOfPeople >= 30)
                    {
                        totalPrice *= 0.85m;
                    }
                    break;
                case "Business":
                    if (groupOfPeople >= 100)
                    {
                        groupOfPeople -= 10;
                    }
                    switch (dayOfTheWeek)
                    {

                        case "Friday":
                            totalPrice = groupOfPeople * 10.90m;
                            break;
                        case "Saturday":
                            totalPrice = groupOfPeople * 15.60m;
                            break;
                        case "Sunday":
                            totalPrice = groupOfPeople * 16.00m;
                            break;
                    }
                    break;
                case "Regular":
                    switch (dayOfTheWeek)
                    {
                        case "Friday":
                            totalPrice = groupOfPeople * 15.00m;
                            break;
                        case "Saturday":
                            totalPrice = groupOfPeople * 20.00m;
                            break;
                        case "Sunday":
                            totalPrice = groupOfPeople * 22.50m;
                            break;
                    }
                    if (groupOfPeople >= 10 && groupOfPeople <= 20)
                    {
                        totalPrice *= 0.95m;
                    }
                    break;
            }

            Console.WriteLine($"Total price: {totalPrice:F2}");

        }
    }
}
