using System;
using System.Globalization;
using System.Linq;

namespace Balanced_Brackets
{
    class Program
    {
        static void Main(string[] args)
        {
            int count = int.Parse(Console.ReadLine());
            string[] array1 = new string[count];

            bool IsValid = true;
            for (int i = 0; i < array1.Length; i++)
            {
                string[] input = Console.ReadLine().Split(' ').ToArray();
                string bracket = input[0];

                if (bracket == "(" || bracket == ")")
                {
                    array1[i] = bracket;
                    //Array.Resize(ref array1, array1.Length + 1);
                    //array1.Concat(new[] { bracket }).ToArray();
                    //array1.Concat(Enumerable.Repeat(bracket, 1)).ToArray();                
                }

            }

            var newArr = string.Join(' ', array1).Split(" ", StringSplitOptions.RemoveEmptyEntries);
            for (int i = 0; i < newArr.Length; i++)
            {
                //if (i + 1 > newArr.Length - 1)
                //{
                //    break;
                //}

                if (newArr[i] == "(" && newArr[i + 1] == ")")
                {
                    IsValid = true;
                    i++;
                }
                else
                {
                    IsValid = false;
                    break;
                }

            }

            if (IsValid)
            {
                Console.WriteLine("BALANCED");
            }
            else if (!IsValid)
            {
                Console.WriteLine("UNBALANCED");
            }

        }
    }
}
