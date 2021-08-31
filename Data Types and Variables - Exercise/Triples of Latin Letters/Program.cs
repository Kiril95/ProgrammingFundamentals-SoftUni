using System;

namespace Triples_of_Latin_Letters
{
    class Program
    {
        static void Main(string[] args)
        {
            int start = int.Parse(Console.ReadLine());

            for (char i = 'a'; i < 'a' + start; i++)
            {
                for (char j = 'a'; j < 'a' + start; j++)
                {
                    for (char k = 'a'; k < 'a' + start; k++)
                    {
                        //char first = (char)(i);
                        //char second = (char)(j);
                        //char third = (char)(k);
                        Console.WriteLine($"{i}{j}{k}");
                        
                    }
                }
            }
        }
    }
}
