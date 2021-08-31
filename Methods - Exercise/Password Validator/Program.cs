using System;
using System.Linq;
using System.Threading;

namespace Password_Validator
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            int convert = input.Length;  // String to integers

            bool CheckLength = Length(input);
            bool FinalForBoth = CheckForBoth(input);
            bool CheckDigits = Digits(input);

            if (CheckLength && FinalForBoth && CheckDigits)
            {
                Console.WriteLine("Password is valid");
            }

            if (!CheckLength)
            {
                Console.WriteLine("Password must be between 6 and 10 characters");
            }
            if (!FinalForBoth)
            {
                Console.WriteLine("Password must consist only of letters and digits");
            }
            if (!CheckDigits)
            {
                Console.WriteLine("Password must have at least 2 digits");
            }

        }

        static bool Length(string input)
        {
            bool NeededLength = false;

            if (input.Length <= 10 && input.Length >= 6)
            {
                NeededLength = true;
            }

            return NeededLength;
        }

        static bool Digits(string input)
        {
            bool MoreThanTwo = false;
            int count = 0;
            int[] digits = new int[] { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

            foreach (var item in input)
            {
                if (char.IsDigit(item))
                {
                    count++;
                }
            }

            if (count >= 2)
            {
                MoreThanTwo = true;
            }

            return MoreThanTwo;
        }

        static bool CheckForBoth(string input)
        {
            bool LettersAndDigits = false;

            foreach (var item in input)
            {
                if (char.IsLetterOrDigit(item))
                {
                    LettersAndDigits = true;
                }
                else
                {
                    LettersAndDigits = false;
                    break;
                }
            }

            return LettersAndDigits;

        }
    }
}
