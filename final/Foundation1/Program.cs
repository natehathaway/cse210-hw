using System;
using System.Collections.Generic;


// Main program
public class Program
{
    public static void Main(string[] args)
    {
        // Create videos
        List<Video> videos = new List<Video>();

        Video video1 = new Video("Video 1", "Author 1", 120);
        video1.Comments.Add(new Comment("Commenter A", "This is a great video!"));
        video1.Comments.Add(new Comment("Commenter B", "I learned a lot from this video."));
        video1.Comments.Add(new Comment("Commenter C", "Amazing content. Thanks for sharing!"));

        Video video2 = new Video("Video 2", "Author 2", 180);
        video2.Comments.Add(new Comment("Commenter X", "Nice video. Keep up the good work!"));
        video2.Comments.Add(new Comment("Commenter Y", "I have a question about this topic."));
        video2.Comments.Add(new Comment("Commenter Z", "Awesome explanation. Clear and concise!"));

        videos.Add(video1);
        videos.Add(video2);

        // Display videos and comments
        foreach (Video video in videos)
        {
            Console.WriteLine("Title: " + video.Title);
            Console.WriteLine("Author: " + video.Author);
            Console.WriteLine("Length: " + video.LengthInSeconds + " seconds");
            Console.WriteLine("Number of Comments: " + video.GetNumberOfComments());

            Console.WriteLine("Comments:");
            foreach (Comment comment in video.Comments)
            {
                Console.WriteLine("- " + comment.CommenterName + ": " + comment.CommentText);
            }

            Console.WriteLine();
        }
    }
}
