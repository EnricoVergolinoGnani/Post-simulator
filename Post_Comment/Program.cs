using System;
using Post_Comment.Entities;

namespace Post_Comment
{
    class Program
    {
        static void Main(string[] args)
        {
            Comment c1 = new Comment("Have a nice trip!");
            Comment c2 = new Comment("Wow that's awesome!");
            Comment c3 = new Comment("https://www.youtube.com/watch?v=wXMD6wmcwvE");

            Post p1 = new Post(
                DateTime.Parse("21/06/2018 13:05:44"),
                "Traveling to New Zealand",
                "I'm going to visit this wonderful country!",
                12);
            p1.AddComment(c1);
            p1.AddComment(c2);
            p1.AddComment(c3);

            Comment c4 = new Comment("Good night");
            Comment c5 = new Comment("May the force be with you :)");
            Post p2 = new Post(
                DateTime.Parse("28/07/2018 23:14:19"),
                "Good night guys",
                "See ya tommorrow",
                5);
            p2.AddComment(c4);
            p2.AddComment(c5);

            Console.WriteLine(p1);
            Console.WriteLine(p2);
        }
    }
}
