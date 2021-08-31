using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;

namespace SoftUni_Exam_Results
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, int> students = new Dictionary<string, int>();
            Dictionary<string, List<string>> languages = new Dictionary<string, List<string>>();
            string command = Console.ReadLine();

            while (command != "exam finished")
            {
                string[] operations = command.Split("-", StringSplitOptions.RemoveEmptyEntries);

                if (operations[1] == "banned")
                {
                    string name = operations[0];
                    students.Remove(name);
                }
                else
                {
                    string name = operations[0];
                    string technology = operations[1];
                    string points = operations[2];
                    if (!languages.ContainsKey(technology))
                    {
                        languages.Add(technology, new List<string> { name });
                    }
                    else
                    {
                        languages[technology].Add(name);
                        //languages[technology].Add(points);
                    }

                    int points2 = int.Parse(operations[2]);
                    if (!students.ContainsKey(name))
                    {                      
                        students.Add(name, points2);
                    }
                    else
                    {
                        if (students[name] < points2)
                        {
                            students[name] = points2;
                        }                     
                    }
                }
                command = Console.ReadLine();

            }
            var orderedStudByPoints = students
                .OrderByDescending(x => x.Value)
                .ThenBy(x => x.Key)
                .ToDictionary(x => x.Key, x => x.Value);

            var orderedSubmissions = languages
                .OrderByDescending(x => x.Value.Count)
                .ThenBy(x => x.Key)
                .ToDictionary(x => x.Key, x => x.Value);

            Console.WriteLine("Results:");
            foreach (var item in orderedStudByPoints)
            {            
                Console.WriteLine($"{item.Key} | {item.Value}");
            }

            Console.WriteLine("Submissions:");
            foreach (var item in orderedSubmissions)
            {
                Console.WriteLine($"{item.Key} - {item.Value.Count}");
            }
        }
    }
}
