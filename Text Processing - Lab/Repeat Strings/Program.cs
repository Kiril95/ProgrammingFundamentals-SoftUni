using System;
using System.Text;

namespace Repeat_Strings
{
    class Program
    {
        static void Main(string[] args)
        {
           // string[] words = Console.ReadLine().Split(" ");
           // string result = string.Empty;
           //
           // foreach (var item in words)
           // {
           //     for (int i = 0; i < item.Length; i++)
           //     {
           //         result += item.ToString();
           //     }
           // }
           // Console.WriteLine(result);

            string[] words = Console.ReadLine().Split(" ");
            StringBuilder result = new StringBuilder();

            foreach (var item in words)
            {
                for (int i = 0; i < item.Length; i++)
                {
                    result.Append(item);
                }
            }
            Console.WriteLine(result);

        }
    }
}
