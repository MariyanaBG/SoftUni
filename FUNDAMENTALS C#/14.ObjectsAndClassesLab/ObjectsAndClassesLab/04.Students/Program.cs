using System;
using System.Collections.Generic;

namespace _04.Students
{
    class Program
    {
        static void Main(string[] args)
        {
            //Define a class Student, which holds the following information about students: first name, last name, age and hometown.
            //Read a list of students until you receive the "end" command. After that, you will receive a name of a city.
            //Print only students, which are from the given city in the following format: "{firstName} {lastName} is {age} years old.".
            //    John Smith 15 Sofia
            //    Peter Ivanov 14 Plovdiv
            //    Linda Bridge 16 Sofia
            //    Simon Stone 12 Varna
            //    end
            //    Sofia
            //                                    John Smith is 15 years old.
            //                                    Linda Bridge is 16 years old.
            //    Anthony Taylor 15 Chicago
            //    David Anderson 16 Washington
            //    Jack Lewis 14 Chicago
            //    David Lee 14 Chicago
            //    end
            //    Chicago
            //                                    Anthony Taylor is 15 years old.
            //                                    Jack Lewis is 14 years old.
            //                                    David Lee is 14 years old.

            List<Student> allStudents = new List<Student>();

            string input = Console.ReadLine();

            while (input != "end")
            {
                string[] studentData = input.Split(' ');
                Student newStudent = new Student();
                newStudent.FirstName = studentData[0];
                newStudent.LastName = studentData[1];
                newStudent.Age = studentData[2];
                newStudent.City = studentData[3];
                allStudents.Add(newStudent);

                input = Console.ReadLine();
            }

            string city = Console.ReadLine();

            foreach (Student student in allStudents)
            {
                if (student.City == city)
                {
                    Console.WriteLine($"{student.FirstName } {student.LastName } is {student.Age } years old.");
                }
            }
        }
    }

    class Student
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Age { get; set; }
        public string City { get; set; }

    }
}
