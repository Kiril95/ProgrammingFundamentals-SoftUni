using System;

namespace Print_Part_Of_ASCII_Table
{
    class Program
    {
        static void Main(string[] args)
        {
            int first = int.Parse(Console.ReadLine());
            int last = int.Parse(Console.ReadLine());


            for (int i = first; i <= last; i++)
            {
                char result = Convert.ToChar(i);
                Console.Write(result + " ");
            }

        }
    }
}
