using System;
using System.Collections.Generic;
using System.Linq;

namespace Students
{
    class Student
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }
        public string Town { get; set; }

        //public override string ToString()
        //{
        //    return $"{FirstName} {LastName} {Age} {Town}";
        //    //return string.Format(this.FirstName, this.LastName, this.Age, this.Town);  
        //}
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

                Student line = new Student();
                line.FirstName = operations[0];
                line.LastName = operations[1];
                line.Age = int.Parse(operations[2]);
                line.Town = operations[3];

                students.Add(line);


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
        // static bool IsStudentExisting(List<Student> students, string firstName, string lastName)
        // {
        //     foreach (Student student in students)
        //     {
        //         if (student.FirstName == firstName && student.LastName == lastName)
        //         {
        //             return true;
        //         }
        //     }                                  Проверява дали даден елемент/име съществува
        //     return false;
        // }

        //if (student.FirstName == firstName && student.LastName == lastName)
        //             {
        //                 exists = student;
        //                 exists.Age = age;      Презаписва даден стойност. В случая Години.
        //             }
        //
    }
}


