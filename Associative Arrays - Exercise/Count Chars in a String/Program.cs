using System;
using System.Collections.Generic;
using System.Linq;

namespace Count_Chars_in_a_String
{
    class Program
    {
        static void Main(string[] args)
        {
            // Първо решение;
            string word = Console.ReadLine();
            // В този случай GroupBy и Select служат, за да мина през всеки един символ
            var result = word
                .Where(x => !Char.IsWhiteSpace(x))
                .GroupBy(x => x) 
                .Select(x => new { Key = x.Key, Counter = x.Count() })
                .ToList();
            
            foreach (var item in result)
            {
                Console.WriteLine($"{item.Key} -> {item.Counter}");
            }

           // Второ решение;
           // string word = Console.ReadLine();
           // Dictionary<char, int> result = new Dictionary<char, int>();
           //
           // foreach (var key in word)
           // {
           //     if (char.IsWhiteSpace(key))
           //     {
           //         continue;
           //     }
           //     //if (char.IsLetterOrDigit(key)
           //     if (!result.ContainsKey(key))
           //     {
           //         result.Add(key, 0);
           //     }
           //     result[key]++;
           //
           // }
           // foreach (var item in result)
           // {
           //     Console.WriteLine($"{item.Key} -> {item.Value}");
           // }

        }
    }
}
