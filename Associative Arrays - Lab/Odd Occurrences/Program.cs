using System;
using System.Collections.Generic;
using System.Linq;

namespace Odd_Occurrences
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] sentence = Console.ReadLine().ToLower().Split(" ");

            Dictionary<string, int> result = new Dictionary<string, int>();

            foreach (var key in sentence)
            {
               // string lowered = key.ToLower();
                if (result.ContainsKey(key))
                {
                    result[key]++;
                }
                else
                {
                    result.Add(key, 1);
                }
            }

            foreach (var item in result)
            {
                if (item.Value % 2 != 0)
                {
                    Console.Write($"{item.Key} ");
                }
            }       

        }
    }
}
