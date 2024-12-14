using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        Activity run = new Running("2024-12-15", 30, 3.0);   // 3 millas
        Activity cycle = new Cycling("2024-12-16", 40, 10.0); // 10 mph
        Activity swim = new Swimming("2024-12-17", 45, 20);   // 20 laps

        List<Activity> activities = new List<Activity> { run, cycle, swim };

        foreach (Activity a in activities)
        {
            Console.WriteLine(a.GetSummary());
        }

        Console.WriteLine("Press ENTER to exit...");
        Console.ReadLine();
    }
}
