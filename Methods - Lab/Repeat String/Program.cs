using System;
using System.Linq;
using System.Text;

namespace Repeat_String
{
    class Program
    {
        static void Main(string[] args)
        {
            string word = Console.ReadLine();
            int count = int.Parse(Console.ReadLine());
            Console.WriteLine(Repeat(word, count));
            
            static string Repeat(string word, int count)  // Масив в метод (params string [] Test)
            {
                return string.Concat(Enumerable.Repeat(word, count));
        
            }
        }

        //static void Main(string[] args)
        //{
        //    string word = Console.ReadLine();
        //    int count = int.Parse(Console.ReadLine());
        //    
        //    string result = StringRepeat(word, count);
        //    Console.Write(result);
        //}
        //
        //private static string StringRepeat(string input, int n)
        //{
        //    StringBuilder result = new StringBuilder();
        //
        //    for (int i = 0; i < n; i++)
        //    {
        //        result.Append(input);
        //    }
        //
        //    return result.ToString();
        //}

    }
}
