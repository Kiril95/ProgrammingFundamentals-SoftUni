using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;

namespace Order_by_Age
{
    public class Student
    {
        public Student(string name, string number, int age)
        {
            Name = name;
            Number = number;     // Конструкторче
            Age = age;
        }
        public string Name { get; set; }
        public string Number { get; set; }
        public int Age { get; set; }
        class Program
        {
            static void Main(string[] args)
            {
                string command = Console.ReadLine();

                List<Student> list = new List<Student>();
                while (command != "End")
                {
                    List<string> operations = command
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                    .ToList();

                    string name = operations[0];
                    string number = operations[1];
                    int age = int.Parse(operations[2]);

                    Student full = new Student(name, number, age);
                    list.Add(full);

                    command = Console.ReadLine();
                }

                list = list.OrderBy(x => x.Age).ToList();
                foreach (Student item in list)
                {
                    Console.WriteLine($"{item.Name} with ID: {item.Number} is {item.Age} years old.");
                }

            }
        }     
    }
}
