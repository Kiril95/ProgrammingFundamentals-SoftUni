using System;
using System.Linq;
using System.Text.RegularExpressions;

namespace Problem_1
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();
            string command = Console.ReadLine();

            while (command != "Complete")
            {
                string[] operations = command.Split(" ", StringSplitOptions.RemoveEmptyEntries);

                if (command == "Make Upper")
                {
                    text = text.Replace(text, text.ToUpper());
                    Console.WriteLine(text);
                }

                else if (command == "Make Lower")
                {
                    text = text.Replace(text, text.ToLower());
                    Console.WriteLine(text);
                }

                else if (operations[0] == "GetDomain")
                {
                    int last = int.Parse(operations[1]);
                    string subs = text.Substring(text.Length - last);

                    Console.WriteLine(subs);
                }

                else if (operations[0] == "GetUsername")
                {
                    if (text.Contains("@"))
                    {
                        Match matched = Regex.Match(text, @"(?<substr>[\w]+)@");
                        string word = matched.Groups["substr"].Value;
                        Console.WriteLine(word.ToString());
                    }
                    else
                    {
                        Console.WriteLine($"The email {text} doesn't contain the @ symbol.");
                    }
                }

                else if (operations[0] == "Replace")
                {
                    string repl = operations[1];
                    while (text.Contains(repl))
                    {
                        text = text.Replace(repl, "-");
                    }
                    Console.WriteLine(text);
                }

                else if (operations[0] == "Encrypt")
                {
                    foreach (char letter in text)
                    {
                        Console.Write($"{Convert.ToInt32(letter)} ");
                    }
                    Console.WriteLine();
                }
                command = Console.ReadLine();

            }          
        }
    }
}
