using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Replace_Repeating_Chars
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();
            StringBuilder result = new StringBuilder();
            char prevChar = '\0'; // Празен чар = null
            
            foreach (var item in text)
            {
                if (item != prevChar)
                {
                    result.Append(item);
                    prevChar = item;
                }
            }
            Console.WriteLine(result);

        }
    }
}
