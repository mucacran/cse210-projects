using System;
using System.Threading;

abstract class Activity
{
    protected int _duration; // en segundos
    
    public void RunActivity()
    {
        ShowStartingMessage();
        PrepareToBegin();
        PerformActivity();
        ShowFinishingMessage();
    }

    // Cada actividad tendrá su propio PerformActivity().
    protected abstract void PerformActivity();

    // Mensaje inicial común
    protected virtual void ShowStartingMessage()
    {
        Console.Clear();
        Console.WriteLine($"Welcome to the {GetName()}.\n");
        Console.WriteLine(GetDescription() + "\n");
        Console.Write("How long, in seconds, would you like for your session? ");
        string input = Console.ReadLine();
        if (!int.TryParse(input, out _duration))
        {
            _duration = 30; // valor por defecto
        }
    }

    // Mensaje final común
    protected virtual void ShowFinishingMessage()
    {
        Console.WriteLine("\nWell done!!");
        ShowSpinner(3);
        Console.WriteLine($"\nYou have completed {_duration} seconds of the {GetName()}.");
        ShowSpinner(3);
    }

    // Método común para pausar con un mensaje de "Get ready..."
    protected void PrepareToBegin()
    {
        Console.Clear();
        Console.WriteLine("Get ready...");
        ShowSpinner(5);
        Console.Write("\n");
    }

    // Spinner para pausas
    protected void ShowSpinner(int seconds)
    {
        DateTime endTime = DateTime.Now.AddSeconds(seconds);
        List<string> spinnerChars = new List<string> { "|", "/", "-", "\\", "|", "/", "-", "\\" };
        int i = 0;
        while (DateTime.Now < endTime)
        {
            Console.Write(spinnerChars[i]);
            Thread.Sleep(250);
            Console.Write("\b \b");
            i++;
            if (i >= spinnerChars.Count)
                i = 0;
        }
    }

    // Cuenta regresiva (para Breathing o para retardos específicos)
    protected void ShowCountdown(int seconds)
    {
        for (int i = seconds; i > 0; i--)
        {
            Console.Write(i);
            Thread.Sleep(1000);
            Console.Write("\b \b");
        }
    }

    protected abstract string GetName();
    protected abstract string GetDescription();
}
