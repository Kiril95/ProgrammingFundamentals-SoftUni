using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace Query_Mess
{
    class Program
    {
        static void Main(string[] args)
        {
            string command = Console.ReadLine();
            Dictionary<string, List<string>> result = new Dictionary<string, List<string>>();

            while (command != "END")
            {
                command = Regex.Replace(command, @"\s+", " ");
                command = command.Replace("+", " ");
                command = command.Replace("%20", " ");
                MatchCollection matches = Regex.Matches(command, @"(?<key>[^&=?]+)=(?<value>[^&=?]+)"); 

                foreach (Match item in matches)
                {
                    string key = item.Groups["key"].Value.Trim();
                    string value = item.Groups["value"].Value.Trim();

                    if (!result.ContainsKey(key))
                    {
                        result.Add(key, new List<string>());
                    }

                    result[key].Add(value);
                }

                command = Console.ReadLine();
            }

            foreach (var item in result)
            {
                Console.Write($"{item.Key}=[" + string.Join(", ", item.Value) + "]");
            }

        }
    }
}
