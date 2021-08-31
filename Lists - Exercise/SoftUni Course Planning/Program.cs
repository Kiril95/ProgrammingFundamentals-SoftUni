using System;
using System.Linq;
using System.Collections.Generic;

namespace SoftUni_course_planning
{
    class Program
    {
        static void Main()
        {
            List<string> numbers = Console.ReadLine()
                    .Split(", ", StringSplitOptions.RemoveEmptyEntries)
                    .ToList();

            string command = Console.ReadLine();           

            while (command != "course start")
            {
                string[] operations = command.Split(':', StringSplitOptions.RemoveEmptyEntries).ToArray();
                string course = operations[1];

                if (operations[0] == "Add")
                {
                    if (!numbers.Contains(course))
                    {
                        numbers.Add(course);
                    }
                }

                else if (operations[0] == "Insert")
                {
                    if (!numbers.Contains(course))
                    {
                        numbers.Insert(int.Parse(operations[2]), course);
                    }                 
                }

                else if (operations[0] == "Remove")
                {
                    if (numbers.Contains(course))
                    {
                        numbers.Remove(course);
                    }
                    else if (numbers.Contains(course + "-Exercise"))
                    {
                        numbers.Remove(course + "-Exercise");
                    }
                }

                else if (operations[0] == "Swap")
                {
                    int index1 = numbers.IndexOf(operations[1]); // Намира индекса на търсеното от нас
                    int index2 = numbers.IndexOf(operations[2]);
                    if (numbers.Contains(operations[1]) && numbers.Contains(operations[2]))
                    {
                        string tempLessonTitle1 = numbers.ElementAt(index1); //Връща елемента на даден индекс
                        numbers[index1] = numbers[index2];
                        numbers[index2] = tempLessonTitle1;
                    }
                                  
                    if (numbers.Contains(operations[1] + "-Exercise") && numbers.Contains(numbers[index1]))
                    {
                        index1 = numbers.IndexOf(operations[1]);
                        numbers.Remove(operations[1] + "-Exercise");
                        numbers.Insert(index1 + 1, operations[1] + "-Exercise");
                    }

                    else if (numbers.Contains(operations[2] + "-Exercise") && numbers.Contains(numbers[index2]))
                    {
                        index2 = numbers.IndexOf(operations[2]);
                        numbers.Remove(operations[2] + "-Exercise");
                        numbers.Insert(index2 + 1, operations[2] + "-Exercise");
                    }
                }

                else if (operations[0] == "Exercise")
                {
                    //string lesson = command[1];
                    if (numbers.Contains(course) && !numbers.Contains(course + "-Exercise"))
                    {
                        int index = numbers.IndexOf(course);
                        numbers.Insert(index + 1, course + "-Exercise");
                    }

                    else if (!numbers.Contains(course))
                    {
                        numbers.Add(course);
                        numbers.Add(course + "-Exercise");
                    }
                }
                command = Console.ReadLine();   
            }

            for (int i = 0; i < numbers.Count; i++)
            {
                Console.WriteLine($"{i + 1}.{numbers[i]}");
            }
        }
    }
}