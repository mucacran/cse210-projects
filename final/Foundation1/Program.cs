using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        // Crear videos
        Video video1 = new Video("Introduction to C#", "Juan Pérez", 300);
        video1.AddComment(new Comment("Ana", "Excellent explanation!"));
        video1.AddComment(new Comment("Carlos", "Very clear video."));
        video1.AddComment(new Comment("Luis", "I liked the part about variables."));

        Video video2 = new Video("Design Patterns", "María García", 600);
        video2.AddComment(new Comment("Pedro", "Could you go into more detail about Singleton?"));
        video2.AddComment(new Comment("Sofía", "Good material, thanks."));
        video2.AddComment(new Comment("Raúl", "This helped me understand the topic better."));

        Video video3 = new Video("Advanced C#: LINQ", "Alejandro Soto", 420);
        video3.AddComment(new Comment("Clara", "This is just what I needed!"));
        video3.AddComment(new Comment("Miguel", "Where can I find more exercises?"));
        video3.AddComment(new Comment("Fátima", "Excellent demonstration."));

        // Lista de videos
        List<Video> videos = new List<Video> { video1, video2, video3 };

        // Mostrar información
        foreach (Video v in videos)
        {
            Console.WriteLine("Title: " + v.GetTitle());
            Console.WriteLine("Autor: " + v.GetAuthor());
            Console.WriteLine("Duration: " + v.GetDuration() + " seconds");
            Console.WriteLine("Number of comments: " + v.GetCommentCount());

            Console.WriteLine("Comments:");
            foreach (Comment c in v.GetComments())
            {
                Console.WriteLine(" - " + c.GetAuthor() + ": " + c.GetText());
            }
            Console.WriteLine();
        }

        Console.WriteLine("Press ENTER to exit...");
        Console.ReadLine();
    }
}
