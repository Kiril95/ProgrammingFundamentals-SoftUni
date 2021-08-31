using System;
using System.Runtime.CompilerServices;
using System.Threading.Channels;

namespace Greater_of_Two_Values
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            if (input == "int")
            {
                int first = int.Parse(Console.ReadLine());
                int second = int.Parse(Console.ReadLine());
                
                Console.WriteLine(GetInteger(first,second));
            }
            else if (input == "char")
            {
                char first = char.Parse(Console.ReadLine());
                char second = char.Parse(Console.ReadLine());

                Console.WriteLine(GetChar(first, second));
            }
            else if (input == "string")
            {
                string first = (Console.ReadLine());
                string second = (Console.ReadLine());

                Console.WriteLine(GetString(first, second));
            }

        }

        static int GetInteger(int firstInt, int secondInt)
        {
            return Math.Max(firstInt, secondInt);
        }

        static char GetChar(char firstChar, char secondChar)
        {
            return (char)Math.Max(firstChar, secondChar);
        }

        static string GetString(string firstStr, string secondStr)
        {
            var compare = firstStr.CompareTo(secondStr);

            if (compare < 0)
            {
                return secondStr;
            }
            else
            {
                return firstStr;
            }
        }
    }
}
