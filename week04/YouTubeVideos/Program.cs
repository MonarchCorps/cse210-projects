using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        List<Video> videos = new List<Video>();

        Video video1 = new Video("Learning C#", "CodeWithSam", 600);
        video1.AddComment(new Comment("Alex", "Great video!"));
        video1.AddComment(new Comment("Jamie", "Very helpful."));
        video1.AddComment(new Comment("Chris", "Thanks for explaining this."));
        videos.Add(video1);

        Video video2 = new Video("Intro to OOP", "DevBasics", 480);
        video2.AddComment(new Comment("Taylor", "This made things clearer."));
        video2.AddComment(new Comment("Morgan", "Nice examples."));
        video2.AddComment(new Comment("Jordan", "Good explanation."));
        videos.Add(video2);

        Video video3 = new Video("Classes and Objects", "LearnFast", 720);
        video3.AddComment(new Comment("Pat", "Easy to follow."));
        video3.AddComment(new Comment("Riley", "Helped a lot."));
        video3.AddComment(new Comment("Casey", "Well done."));
        videos.Add(video3);

        foreach (Video video in videos)
        {
            Console.WriteLine($"Title: {video._title}");
            Console.WriteLine($"Author: {video._author}");
            Console.WriteLine($"Length: {video._lengthInSeconds} seconds");
            Console.WriteLine($"Number of comments: {video.GetNumberOfComments()}");

            foreach (Comment comment in video.GetComments())
            {
                Console.WriteLine($"- {comment._commenterName}: {comment._text}");
            }

            Console.WriteLine();
        }
    }
}
