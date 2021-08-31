using System;
using System.IO;
using System.Text;
using System.Text.RegularExpressions;

namespace Use_Your_Chains__Buddy
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.SetIn(new StreamReader(Console.OpenStandardInput(8192)));
            // Позволява да вкарам особено дълъг инпут

            var text = Console.ReadLine();
            const string pattern = "(?<=<p>).*?(?=<\\/p>)";
            var regex = new Regex(pattern);
            var sb = new StringBuilder();
            //MatchCollection matches = regex.Matches(text, @"((?<=<p>).*?(?=<\\/p>)");
            foreach (Match match in regex.Matches(text))
            {
                var replaced = Regex.Replace(match.ToString(), "[^a-z0-9]", " ");
                for (var i = 0; i < replaced.Length; i++)
                {
                    char ch = replaced[i];
                    if (char.IsLower(replaced[i]))
                    {
                        if (replaced[i] < 110)
                        {
                            sb.Append((char)(ch + 13));
                        }
                        else if (replaced[i] >= 110)
                        {
                            sb.Append((char)(ch - 13));
                        }
                    }
                    else
                    {
                        sb.Append(replaced[i]);
                    }
                }
            }
            Console.WriteLine(Regex.Replace(sb.ToString(), "\\s+", " "));
        }
    }
}
