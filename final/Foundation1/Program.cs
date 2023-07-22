using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
      
        Video video1 = new Video
        {
            Title = "How to code",
            Author = "John Doe",
            Length = 300
        };
        video1.Comments.Add(new Comment { CommenterName = "Frank", CommentText = "Great video!" });
        video1.Comments.Add(new Comment { CommenterName = "Jenna", CommentText = "Nice work!" });

        Video video2 = new Video
        {
            Title = "Coding is hard",
            Author = "Zach",
            Length = 480
        };
        video2.Comments.Add(new Comment { CommenterName = "Hayden", CommentText = "So true!" });
        video2.Comments.Add(new Comment { CommenterName = "Eric", CommentText = "You're just dumb!" });

        Video video3 = new Video
        {
            Title = "Ice Cream is delicious",
            Author = "Ben and Jerry",
            Length = 600
        };
        video3.Comments.Add(new Comment { CommenterName = "Fred", CommentText = "Thanks for sharing!" });
        video3.Comments.Add(new Comment { CommenterName = "User 3", CommentText = "Awesome!" });

     
        List<Video> videos = new List<Video> { video1, video2, video3 };

      
        foreach (Video video in videos)
        {
            Console.WriteLine($"Title: {video.Title}");
            Console.WriteLine($"Author: {video.Author}");
            Console.WriteLine($"Length: {video.Length} seconds");
            Console.WriteLine($"Number of Comments: {video.GetNumberOfComments()}");
            Console.WriteLine("Comments:");
            foreach (Comment comment in video.Comments)
            {
                Console.WriteLine($"- {comment.CommenterName} says: {comment.CommentText}");
            }
            Console.WriteLine();
        }
    }
}