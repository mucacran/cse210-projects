using System;
using System.Collections.Generic;
using System.Threading;

class ListingActivity : Activity
{
    private List<string> _prompts = new List<string>
    {
        "Who are people that you appreciate?",
        "What are personal strengths of yours?",
        "Who are people that you have helped this week?",
        "When have you felt the Holy Ghost this month?",
        "Who are some of your personal heroes?"
    };

    protected override string GetName()
    {
        return "Listing Activity";
    }

    protected override string GetDescription()
    {
        return "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.";
    }

    protected override void PerformActivity()
    {
        Random rand = new Random();
        string prompt = _prompts[rand.Next(_prompts.Count)];
        
        Console.WriteLine("\nList as many responses as you can to the following prompt:");
        Console.WriteLine($"--- {prompt} ---");

        Console.Write("You may begin in: ");
        ShowCountdown(5);

        DateTime endTime = DateTime.Now.AddSeconds(_duration);
        int count = 0;
        
        Console.WriteLine("Start listing items (press enter after each item):");
        
        Console.Write("> ");
        while (DateTime.Now < endTime)
        {
            // Leer items hasta que se acabe el tiempo
            if (Console.KeyAvailable)
            {
                

                string item = Console.ReadLine();

                // para que no se imprima ">" en la siguiente línea
                if (DateTime.Now < endTime)
                {
                    Console.Write("> ");
                }
                
                if (!string.IsNullOrWhiteSpace(item))
                {
                    count++;
                }
            }
            else
            {
                // Si el usuario no presiona nada, solo esperamos brevemente
                Thread.Sleep(200);
            }
        }

        Console.WriteLine($"\nYou listed {count} items!");
    }
}
