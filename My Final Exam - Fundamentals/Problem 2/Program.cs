using System;
using System.Text.RegularExpressions;

namespace Problem_2
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int counter = 0;

            for (int i = 0; i < n; i++)
            {
                string command = Console.ReadLine();
                Match matched = Regex.Match(command, @"\b[U$]+(?<user>[A-Z][a-z]{2,})[U$]+[P@$]+(?<pass>[A-Za-z]{5,}[\d]+)[P@$]+");

                if (matched.Success)
                {
                    counter++;
                    string user = matched.Groups["user"].Value;
                    string pass = matched.Groups["pass"].Value;

                    Console.WriteLine("Registration was successful");
                    Console.WriteLine($"Username: {user}, Password: {pass}");
                }
                else
                {
                    Console.WriteLine("Invalid username or password");
                }
            }
            Console.WriteLine($"Successful registrations: {counter}");
        }
    }
}
