using System;
using System.Globalization;
using System.Linq;

namespace Messages
{
    class Program
    {
        static void Main(string[] args)
        {
            int count = int.Parse(Console.ReadLine());
            string word = string.Empty;

            for (int i = 0; i < count; i++)
            {
                string nums = Console.ReadLine();

                int len = nums.Length;
                int first = int.Parse(nums[0].ToString()); //Намира първия елемент
                int offset = (first - 2) * 3;

                if (first == 8 || first == 9)
                {
                    offset++;
                }

                if (first == 0)
                {
                    word += (char)(first + 32);
                    continue;
                }

                var idx = offset + len - 1;
                word += (char)(idx + 97);
                
            }
            Console.WriteLine(word);
        }
    }
}
