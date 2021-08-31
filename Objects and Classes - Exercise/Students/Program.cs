using System;
using System.Collections.Generic;
using System.Linq;

namespace Students
{
    class Student
    {
        public Student(string firstName, string lastName, float grade)
        {
            FirstName = firstName;
            LastName = lastName;     // Конструкторче
            Grade = grade;
        }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public float Grade { get; set; }
    
        class Program
        {
            static void Main(string[] args)
            {
                int count = int.Parse(Console.ReadLine());

                List<Student> people = new List<Student>();
                for (int i = 0; i < count; i++)
                {
                    List<string> operations = Console.ReadLine()
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                    .ToList();

                    string firstName = operations[0];
                    string lastName = operations[1];
                    float grade = float.Parse(operations[2]);

                    Student list = new Student(firstName, lastName, grade);
                    people.Add(list);
                }
                Console.WriteLine();
                people = people.OrderByDescending(x => x.Grade).ToList();

                foreach (Student item in people)
                {                
                    Console.WriteLine($"{item.FirstName} {item.LastName}: {item.Grade:f2}");
                }

            }
        }       
    }          
}
