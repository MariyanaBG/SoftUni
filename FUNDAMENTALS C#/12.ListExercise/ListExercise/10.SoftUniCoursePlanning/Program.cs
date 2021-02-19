using System;
using System.Collections.Generic;
using System.Linq;

namespace _10.SoftUniCoursePlanning
{
    class Program
    {
        static void Main(string[] args)
        {
            //On the first line you will receive the initial schedule of the lessons and the exercises that are going
            //to be a part of the next course, separated by comma and space ", ".But before the course starts, 
            //some changes should be made.Until you receive "course start" you will be given some commands 
            //to modify the course schedule.The possible commands are: 
            //    Add:{ lessonTitle} – add the lesson to the end of the schedule, if it does not exist.
            //    Insert:{ lessonTitle}:{ index} – insert the lesson to the given index, if it does not exist.
            //    Remove:{ lessonTitle} – remove the lesson, if it exists.
            //    Swap:{ lessonTitle}:{ lessonTitle} – change the place of the two lessons, if they exist.
            //    Exercise:{ lessonTitle} – add Exercise in the schedule right after the lesson index,
            //            if the lesson exists and there is no exercise already, in the following format "{lessonTitle}-Exercise".
            //            If the lesson doesn`t exist, add the lesson in the end of the course schedule, followed by the Exercise.
            //    Each time you Swap or Remove a lesson, you should do the same with the Exercises, if there are any, 
            //    which follow the lessons.
            //    Print the whole course schedule, each lesson on a new line with its number(index) in the schedule: 
            //"{lesson index}.{lessonTitle}"
            //    Data Types, Objects, Lists
            //    Add: Databases
            //    Insert:Arrays: 0
            //    Remove: Lists
            //    course start
            //                        1.Arrays
            //                        2.Data Types
            //                        3.Objects
            //                        4.Databases

            //    Arrays, Lists, Methods
            //    Swap: Arrays: Methods
            //    Exercise:Databases
            //    Swap:Lists: Databases
            //    Insert:Arrays: 0
            //    course start
            //                        1.Methods
            //                        2.Databases
            //                        3.Databases - Exercise
            //                        4.Arrays
            //                        5.Lists

            List<string> lessons = Console.ReadLine().Split(", ").ToList();
            string input = Console.ReadLine();

            while (input != "course start")
            {
                string[] textParts = input.Split(':');
                switch (textParts[0])
                {
                    case "Add":
                        if (!lessons.Contains(textParts[1]))
                        {
                            lessons.Add(textParts[1]);
                        }
                        break;

                    case "Insert":
                        string lessonTitle = textParts[1];
                        int index = int.Parse(textParts[2]);
                        if (!lessons.Contains(lessonTitle))
                        {
                            lessons.Insert(index, lessonTitle);
                        }
                        break;

                    case "Remove":
                        lessonTitle = textParts[1];
                        if (lessons.Contains(lessonTitle))
                        {
                            lessons.Remove(lessonTitle);
                        }

                        if (lessons.Contains($"{lessonTitle}-Exercise"))
                        {
                            lessons.Remove($"{lessonTitle}-Exercise");
                        }
                        break;

                    case "Swap":
                        string lesson1 = textParts[1];
                        string lesson2 = textParts[2];
                        if (lessons.Contains(lesson1) && lessons.Contains(lesson2))
                        {
                            int indexLesson1 = lessons.IndexOf(lesson1);
                            int indexLesson2 = lessons.IndexOf(lesson2);

                            if (lessons.Contains(lesson1) && lessons.Contains(lesson2))
                            {
                                string tempLessonTitle1 = lessons.ElementAt(indexLesson1);
                                lessons[indexLesson1] = lessons[indexLesson2];
                                lessons[indexLesson2] = tempLessonTitle1;
                            }

                            if (lessons.Contains(lesson1 + "-Exercise") && lessons.Contains(lessons[indexLesson1]))
                            {
                                indexLesson1 = lessons.IndexOf(lesson1);
                                lessons.Remove(lesson1 + "-Exercise");
                                lessons.Insert(indexLesson1 + 1, lesson1 + "-Exercise");
                            }
                            else if (lessons.Contains(lesson2 + "-Exercise") && lessons.Contains(lessons[indexLesson2]))
                            {
                                indexLesson2 = lessons.IndexOf(lesson2);
                                lessons.Remove(lesson2 + "-Exercise");
                                lessons.Insert(indexLesson2 + 1, lesson2 + "-Exercise");
                            }

                        }
                        break;

                    case "Exercise":
                        lessonTitle = textParts[1];

                        if (lessons.Contains(lessonTitle) && !lessons.Contains($"{lessonTitle}-Exercise"))
                        {
                            index = lessons.IndexOf(lessonTitle);
                            lessons.Insert(index + 1, $"{lessonTitle}-Exercise");
                        }
                        else
                        {
                            lessons.Add(lessonTitle);
                            lessons.Add($"{lessonTitle}-Exercise");
                        }
                        break;
                       


                }

                input = Console.ReadLine();
            }

            for (int i = 0; i < lessons.Count; i++)
            {
                Console.WriteLine($"{i + 1}.{lessons[i]}");
            }
        }
    }
}
