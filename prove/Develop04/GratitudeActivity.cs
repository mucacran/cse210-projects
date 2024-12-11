using System;
using System.Collections.Generic;
using System.Threading;

class GratitudeActivity : Activity
{


    protected override string GetName()
    {
        return "Gratitude Activity";
    }

    protected override string GetDescription()
    {
        return "Please take a few moments to think of at least 3 things you are grateful for.";
    }

    protected override void PerformActivity()
    {
        
        Console.WriteLine("\nList as many answers as you can:");
        Console.WriteLine($"--- {GetDescription()} ---");

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
