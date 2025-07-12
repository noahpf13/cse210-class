using System;
using System.Collections.Generic;

class Comment
{
    public string Name;
    public string Text;
}

class Video
{
    public string Title;
    public string Author;
    public int Length;
    public List<Comment> Comments = new List<Comment>();

    public int GetNumberOfComments()
    {
        return Comments.Count;
    }

    public void Display()
    {
        Console.WriteLine($"Title: {Title}");
        Console.WriteLine($"Author: {Author}");
        Console.WriteLine($"Length: {Length} seconds");
        Console.WriteLine($"Number of Comments: {GetNumberOfComments()}");
        Console.WriteLine("Comments:");
        foreach (var comment in Comments)
        {
            Console.WriteLine($"- {comment.Name}: {comment.Text}");
        }
        Console.WriteLine();
    }
}

class Program
{
    static void Main()
    {
        List<Video> videos = new List<Video>();

        Video video1 = new Video
        {
            Title = "Learn C# Basics",
            Author = "CodeWithSam",
            Length = 600
        };
        video1.Comments.Add(new Comment { Name = "Alice", Text = "Great intro!" });
        video1.Comments.Add(new Comment { Name = "Bob", Text = "Thanks for the tips." });
        video1.Comments.Add(new Comment { Name = "Clara", Text = "Helped me a lot!" });

        Video video2 = new Video
        {
            Title = "BYU Devotional Highlights",
            Author = "BYUI Spiritual",
            Length = 900
        };
        video2.Comments.Add(new Comment { Name = "Eve", Text = "Very uplifting." });
        video2.Comments.Add(new Comment { Name = "Frank", Text = "needed this" });
        video2.Comments.Add(new Comment { Name = "Grace", Text = "Loved it!" });

        Video video3 = new Video
        {
            Title = "Powerlifting Tips",
            Author = "LiftHouse",
            Length = 750
        };
        video3.Comments.Add(new Comment { Name = "Henry", Text = "Going to try this!" });
        video3.Comments.Add(new Comment { Name = "Ivy", Text = "That bench setup was clean." });
        video3.Comments.Add(new Comment { Name = "Jake", Text = "Respect" });

        videos.Add(video1);
        videos.Add(video2);
        videos.Add(video3);

        foreach (var video in videos)
        {
            video.Display();
        }

        Console.ReadKey();
    }
}
