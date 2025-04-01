using System;
using System.Collections.Generic;
using YouTubeVideoSystem.Models;

class Program
{
    static void Main()
    {
        Video video1 = new Video("OOP Basics", "John Doe", 300);
        video1.AddComment(new Comment("Alice", "Great explanation!"));
        video1.AddComment(new Comment("Bob", "Very helpful."));
        
        List<Video> videos = new List<Video> { video1 };

        foreach (var video in videos)
        {
            video.DisplayInfo();
            Console.WriteLine();
        }
    }
}
