using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Linq;

namespace Articles_2._0
{
    class Articles
    {
        public Articles(string title, string content, string author)
        {
            Title = title;
            Content = content;     // Конструкторче
            Author = author;
        }
        public string Title { get; set; }
        public string Content { get; set; }
        public string Author { get; set; }

        public override string ToString()
        {
            return $"{Title} {Content} {Author}";
            //return string.Format(this.Rename, this.Edit, this.ChangeAuthor);  //Презаписва
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            List<Articles> final = new List<Articles>();
            for (int i = 0; i < n; i++)
            {
                List<string> operations = Console.ReadLine()
                .Split(", ", StringSplitOptions.RemoveEmptyEntries)
                .ToList();

                string title = operations[0];
                string content = operations[1];
                string author = operations[2];

                Articles list = new Articles(title, content, author);
                final.Add(list);

            }
            string word = Console.ReadLine();

            if (word == "title")
            {
                final = final.OrderBy(x => x.Title).ToList();
            }
            else if (word == "content")
            {
                final = final.OrderBy(x => x.Content).ToList();
            }
            else if (word == "author")
            {
                final = final.OrderBy(x => x.Author).ToList();
            }

            foreach (Articles item in final)
            {
                Console.WriteLine($"{item.Title} - {item.Content}: {item.Author}");
            }       
        }

    }
}
