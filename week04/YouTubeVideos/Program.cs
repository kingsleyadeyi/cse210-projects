using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        // Create the videos
        Video video1 = new Video(
            "Learning C# Classes",
            "Programming Academy",
            600
        );

        Video video2 = new Video(
            "Introduction to Object-Oriented Programming",
            "Code School",
            720
        );

        Video video3 = new Video(
            "Understanding Abstraction",
            "Developer Tutorials",
            480
        );

        // Add comments to Video 1
        video1.AddComment(new Comment(
            "John",
            "This was very helpful!"
        ));

        video1.AddComment(new Comment(
            "Mary",
            "I finally understand classes."
        ));

        video1.AddComment(new Comment(
            "David",
            "Great explanation."
        ));

        // Add comments to Video 2
        video2.AddComment(new Comment(
            "Sarah",
            "I learned a lot from this video."
        ));

        video2.AddComment(new Comment(
            "Michael",
            "The examples were easy to follow."
        ));

        video2.AddComment(new Comment(
            "James",
            "Excellent tutorial."
        ));

        // Add comments to Video 3
        video3.AddComment(new Comment(
            "Linda",
            "Abstraction makes much more sense now."
        ));

        video3.AddComment(new Comment(
            "Robert",
            "Thank you for explaining this clearly."
        ));

        video3.AddComment(new Comment(
            "Grace",
            "Very useful lesson."
        ));

        // Put the videos into a list
        List<Video> videos = new List<Video>
        {
            video1,
            video2,
            video3
        };

        // Display each video
        foreach (Video video in videos)
        {
            video.Display();
        }
    }
}