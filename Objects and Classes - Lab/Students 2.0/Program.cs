using System;
using System.Collections.Generic;
using System.Linq;

namespace Students_2._0
{
    class Student
    {
        public Student(string firstName, string lastName, int age, string town)
        {
            FirstName = firstName;
            LastName = lastName;     // Конструкторче
            Age = age;
            Town = town;
        }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }
        public string Town { get; set; }

        public override string ToString()
        {
            //return $"{FirstName} {LastName} {Age} {Town}";
            return string.Format(this.FirstName, this.LastName, this.Age, this.Town);  //Презаписва
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            string command = Console.ReadLine();

            List<Student> students = new List<Student>();

            while (command != "end")
            {
                string[] operations = command.Split(" ").ToArray();

                string firstName = operations[0];
                string lastName = operations[1];
                int age = int.Parse(operations[2]);
                string town = operations[3];

                if (IfExists(students, firstName, lastName, age))
                {
                    Student exists = null;
                    foreach (Student student in students)
                    {
                        if (student.FirstName == firstName && student.LastName == lastName)
                        {
                            exists = student;
                            exists.Age = age;
                        }
                    }
                }

                else
                {
                    Student line = new Student(firstName, lastName, age, town);
                    students.Add(line);
                }
              
               // line.FirstName = operations[0];
               // line.LastName = operations[1];
               // line.Age = int.Parse(operations[2]);
               // line.Town = operations[3];            

                command = Console.ReadLine();
            }
            string final = Console.ReadLine();

            foreach (Student person in students)
            {
                if (person.Town == final)
                {
                    Console.WriteLine($"{person.FirstName} {person.LastName} is {person.Age} years old.");
                }

            }
        }

        static bool IfExists(List<Student> students, string firstName, string lastName, int age)
        {
            foreach (Student student in students)
            {
                if (student.FirstName == firstName && student.LastName == lastName)
                {
                    return true;
                }
            }
            return false;
        }
       
    }
}
