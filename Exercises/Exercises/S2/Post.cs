using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Exercises.S2
{
    public class Post
    {
        private string Title { get; set; }
        private string Description { get; set; }

        private DateTime DateAndTime { get; set; }

        private int Votes { get; set; }

        public Post()
        {
            Run();
        }

        public Post(string title, string description)
        {
            Title = title;
            Description = description;

            Run();
        }

        public void UpVote()
        {
            Votes++;
        }

        public void DownVote()
        {
            Votes--;
        }

        public void DisplayVote()
        {
            Console.WriteLine($"Votes: {Votes}");
        }

        public void DisplayPost()
        {
            Console.WriteLine($"Title: {Title}");
            Console.WriteLine($"Description: {Description}");
        }

        public void Run()
        {
            string? input = null;
            while (input != "quit" && input != "5")
            {
                Console.Write(
                    "Options:\n1. up-vote\n2. down-vote\n3. display-vote\n4. display-post\n5. quit\n Please enter option: "
                );
                input = Console.ReadLine().Trim().ToLower();

                switch (input)
                {
                    case "1":
                    case "up-vote":
                        UpVote();
                        break;
                    case "2":
                    case "down-vote":
                        DownVote();
                        break;
                    case "3":
                    case "display-vote":
                        DisplayVote();
                        break;
                    case "4":
                    case "display-post":
                        DisplayPost();
                        break;
                    default:
                        break;
                }
            }
        }
    }
}
