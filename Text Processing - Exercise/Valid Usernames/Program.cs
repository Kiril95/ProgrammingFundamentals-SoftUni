using System;

namespace Valid_Usernames
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] sequence = Console.ReadLine().Split(", ", StringSplitOptions.RemoveEmptyEntries);

            for (int i = 0; i < sequence.Length; i++)
            {
                bool isValid = Valid(sequence[i]);
                if (sequence[i].Length >= 3 && sequence[i].Length <= 16
                    && isValid == true)
                {
                    Console.WriteLine(sequence[i]);
                }

            }          
        }
        //Трябва да си изкарам метод, иначе нещо гърми
        private static bool Valid(string user)
        {
            foreach (var item in user)
            {
                if (char.IsLetterOrDigit(item) || item == '-' || item == '_')
                {
                    continue;
                }
                else
                {
                    return false;
                }
            }
            return true;
        }
    }
}
