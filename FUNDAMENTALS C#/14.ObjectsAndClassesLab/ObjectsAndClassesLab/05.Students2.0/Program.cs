using System;
using System.Collections.Generic;

namespace _04.Students
{
    class Program
    {
        static void Main(string[] args)
        {
            //Use the class from the previous problem.If you receive a student, which already exists(first name and last name 
            //should be unique) overwrite the information.
            //    John Smith 15 Sofia
            //    Peter Ivanov 14 Plovdiv
            //    Peter Ivanov 25 Plovdiv
            //    Linda Bridge 16 Sofia
            //    Linda Bridge 27 Sofia
            //    Simon Stone 12 Varna
            //    end
            //    Sofia
            //                                        John Smith is 15 years old.
            //                                        Linda Bridge is 27 years old.
            //    Anthony Taylor 15 Chicago
            //    David Anderson 16 Washington
            //    Jack Lewis 14 Chicago
            //    David Lee 14 Chicago
            //    Jack Lewis 26 Chicago
            //    David Lee 18 Chicago
            //    end
            //    Chicago
            //                                        Anthony Taylor is 15 years old.
            //                                        Jack Lewis is 26 years old.
            //                                        David Lee is 18 years old.

            List<Student> allStudents = new List<Student>();

            string input = Console.ReadLine();

            while (input != "end")
            {
                string[] studentData = input.Split(' ');
                string firstName = studentData[0];
                string lastName = studentData[1];
                int age = int.Parse(studentData[2]);
                string city = studentData[3];

                if (IsStudentExisting(allStudents, firstName, lastName))
                {
                    Student existingStudent = GetStudent(allStudents, firstName, lastName);
                    existingStudent.Age = age;
                    existingStudent.City = city;
                }
                else
                {
                    Student newStudent = new Student();
                    newStudent.FirstName = firstName;
                    newStudent.LastName = lastName;
                    newStudent.Age = age;
                    newStudent.City = city;
                    allStudents.Add(newStudent);
                }

                input = Console.ReadLine();
            }

            string studentsFromCity = Console.ReadLine();

            foreach (Student student in allStudents)
            {
                if (student.City == studentsFromCity)
                {
                    Console.WriteLine($"{student.FirstName } {student.LastName } is {student.Age } years old.");
                }
            }

        }

        private static Student GetStudent(List<Student> allStudents, string firstName, string lastName)
        {
            Student existingStudent = new Student();
            foreach (Student currentStudent in allStudents)
            {
                if (currentStudent.FirstName == firstName && currentStudent.LastName == lastName)
                {
                    existingStudent = currentStudent;
                }
            }
            return existingStudent;
        }

        private static bool IsStudentExisting(List<Student> allStudents, string firstName, string lastName)
        {
            foreach (Student currentStudent in allStudents)
            {
                if (currentStudent.FirstName == firstName && currentStudent.LastName == lastName)
                {
                    return true;
                }
            }

            return false;
        }
    }

    class Student
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }
        public string City { get; set; }

    }
}
