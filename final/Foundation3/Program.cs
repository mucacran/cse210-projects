using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        Address addr1 = new Address("123 Main St", "Springfield", "IL", "USA");
        Lecture lecture = new Lecture("C# Advanced", "A deep dive into C# features", "12/12/2024", "10:00 AM", addr1, "John Doe", 100);

        Address addr2 = new Address("456 Park Ave", "Miami", "FL", "USA");
        Reception reception = new Reception("Networking Event", "Business reception with partners", "01/05/2025", "7:00 PM", addr2, "rsvp@company.com");

        Address addr3 = new Address("789 Beach Dr", "Santa Monica", "CA", "USA");
        OutdoorGathering outdoor = new OutdoorGathering("Beach Cleanup", "Community event to clean the beach", "15/06/2025", "9:00 AM", addr3, "Sunny, 75°F");

        List<Event> events = new List<Event> { lecture, reception, outdoor };

        foreach (Event ev in events)
        {
            Console.WriteLine("Standard Details:\n" + ev.GetStandardDetails());
            Console.WriteLine("\nFull Details:\n" + ev.GetFullDetails());
            Console.WriteLine("\nShort Description:\n" + ev.GetShortDescription());
            Console.WriteLine("----------------------------------------\n");
        }

        Console.WriteLine("Presiona ENTER para salir...");
        Console.ReadLine();
    }
}
