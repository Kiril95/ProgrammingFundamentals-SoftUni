using System;

namespace Chars_to_String
{
    class Program
    {
        static void Main(string[] args)
        {           
            char input1 = char.Parse(Console.ReadLine());
            char input2 = char.Parse(Console.ReadLine());
            char input3 = char.Parse(Console.ReadLine());
            
            char[] inputs = { input1, input2, input3 };
            string test = new string(inputs);

            //string con = string.Concat(input1, input2, input3);

            Console.WriteLine(test);
        }
    }
}
