using System;
using System.Linq;

namespace Kamino_Factory
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int copySum = 0;
            int copyIndex = 0;
            int copySeq = 0;
            int counter = 0;
            int copyCount = 1;

            string[] copyArray = null;

            while (true)
            {
                string command = Console.ReadLine();
                if (command == "Clone them!")
                {
                    break;
                }

                string[] array1 = command.Split('!', StringSplitOptions.RemoveEmptyEntries);
                counter++;
                int sum = 0;

                for (int i = 0; i < array1.Length; i++)
                {
                    //sum = array1.Select(int.Parse).Sum();
                    if (array1[i] == "1")
                    {
                        sum++;
                    }
                }

                int Index = 1;
                int sequences = 1;

                for (int i = 0; i < array1.Length; i++)
                {
                    if (array1[i] == "1")
                    {
                        sequences++;

                        if (sequences == 1)
                        {
                            Index = i;                                              
                        }

                        if (sequences > copySeq || sequences == copySeq
                            && Index < copyIndex || sum > copySum)
                        {
                            copySeq = sequences;
                            copyIndex = Index;
                            copyCount = counter;
                            copyArray = array1.ToArray(); //Когато записваме масив в друг, трябва да е така.
                            copySum = sum;

                        }
                    }

                    else
                    {
                        sequences = 0;
                        Index = 0;

                    }

                }
          
            }
            //if (copyCount == 0)
            //{
            //    copyCount = 1;
            //}
            Console.WriteLine($"Best DNA sample {copyCount} with sum: {copySum}.");
            Console.WriteLine(string.Join(' ', copyArray));
        }
    }
}
