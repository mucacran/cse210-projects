using System;
using System.Threading;

class BreathingActivity : Activity
{
    protected override string GetName()
    {
        return "Breathing Activity";
    }

    protected override string GetDescription()
    {
        return "This activity will help you relax by guiding you through slow breathing. Clear your mind and focus on your breathing.";
    }

    protected override void PerformActivity()
    {
        // En el tiempo total, alternar "Breathe in..." y "Breathe out..."
        // Suponiendo un ciclo de 2 frases (in y out) de ~5 segundos cada una.
        
        DateTime endTime = DateTime.Now.AddSeconds(_duration);
        bool breathingIn = true;
        
        while (DateTime.Now < endTime)
        {
            if (breathingIn)
            {
                Console.Write("\nBreathe in...");
                ShowCountdown(4); // 4 seg 
            }
            else
            {
                Console.Write("\nNow Breathe out...");
                ShowCountdown(4); // 4 seg
                Console.Write("\n");
            }
            breathingIn = !breathingIn;
        }

    }
}
