using System;
using System.Linq;

namespace Reverse_Strings
{
    class Program
    {
        static void Main(string[] args)
        {
            string command = Console.ReadLine();

            while (command != "end")
            {
                char[] charr = command.ToCharArray();
                Array.Reverse(charr);
                Console.WriteLine($"{command} = {new string(charr)}"); //"Подчертаваме", че е нов стринг

                command = Console.ReadLine();
            }

        }
    }
}
