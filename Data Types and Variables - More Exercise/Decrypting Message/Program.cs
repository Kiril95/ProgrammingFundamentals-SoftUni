using System;

namespace Decrypting_Message
{
    class Program
    {
        static void Main(string[] args)
        {
            int key = int.Parse(Console.ReadLine());
            int count = int.Parse(Console.ReadLine());
            string word = " ";

            for (int i = 0; i < count; i++)
            {
                char letter = char.Parse(Console.ReadLine());
                    // Четем буквата след това добавяме (key) към Аски стойността на буквата
                    // и намираме позицията на новополучената буква
                char current = (char)(letter + (char)key);
                word += current;
                //char current = char.Parse(letter);
                //word = letter + (char)key;
            }
            Console.WriteLine(word);

        }
    }
}
