using System;
using System.Text;
using System.Text.RegularExpressions;

namespace Activation_Keys
{
    class Program
    {
        static void Main(string[] args)
        {
            string activationKey = Console.ReadLine();
            string command = Console.ReadLine();
            // StringBuilder sb = new StringBuilder(activationKey);

            while (command != "Generate")
            {
                string[] operations = command.Split(">>>");

                if (operations[0] == "Slice")
                {
                    int start = int.Parse(operations[1]);
                    int end = int.Parse(operations[2]);
                    string subs = activationKey.Substring(start, end - start);
                    activationKey = Regex.Replace(activationKey, $@"{subs}", string.Empty);

                    Console.WriteLine(activationKey);
                }
                else if (operations[0] == "Flip")
                {
                    int start = int.Parse(operations[2]);
                    int end = int.Parse(operations[3]);
                    string subs = activationKey.Substring(start, end - start);

                    if (operations[1] == "Upper")
                    {
                        activationKey = Regex.Replace(activationKey, $@"{subs}", subs.ToUpper());
                    }
                    else
                    {
                        activationKey = Regex.Replace(activationKey, $@"{subs}", subs.ToLower());
                    }
                    Console.WriteLine(activationKey);
                }
                else
                {
                    if (activationKey.Contains(operations[1]))
                    {
                        Console.WriteLine($"{activationKey} contains {operations[1]}");
                    }
                    else
                    {
                        Console.WriteLine("Substring not found!");
                    }
                }

                command = Console.ReadLine();
            }
            Console.WriteLine($"Your activation key is: {activationKey}");


        }
    }
}
