using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        List<Video> videos = new List<Video>();

        // Create Video 1
        Video video1 = new Video
        {
            Title = "C# Programming",
            Author = "Claude",
            LengthInSeconds = 600
        };
        video1.AddComment(new Comment { CommenterName = "John", CommentText = "Great video!" });
        video1.AddComment(new Comment { CommenterName = "Antonny", CommentText = "Very helpful" });
        video1.AddComment(new Comment { CommenterName = "Mark", CommentText = "I learned a lot, thanks!" });

        // Create Video 2
        Video video2 = new Video
        {
            Title = "C# Techniques",
            Author = "Jarvis",
            LengthInSeconds = 900
        };
        video2.AddComment(new Comment { CommenterName = "Jackie Chan", CommentText = "Very cool" });
        video2.AddComment(new Comment { CommenterName = "Emily", CommentText = "This helped me a lot" });

        // Create Video 3
        Video video3 = new Video
        {
            Title = "Debugging Tips",
            Author = "Lunox",
            LengthInSeconds = 720
        };
        video3.AddComment(new Comment { CommenterName = "Alfred", CommentText = "Really useful, thanks!" });
        video3.AddComment(new Comment { CommenterName = "Sarah", CommentText = "I didn't like it man" });
        video3.AddComment(new Comment { CommenterName = "Fernando", CommentText = "Clear explanation, I liked it" });

        videos.Add(video1);
        videos.Add(video2);
        videos.Add(video3);

        foreach (var video in videos)
        {
            video.DisplayInformation();
        }
    }
}
