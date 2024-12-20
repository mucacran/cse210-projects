using System;
//are un sistema para reservar en el gimnacio

class Program
{
    static void Main(string[] args)
    {
        
        bool running = true;
        
        while (running)
        {
            Console.Clear();
            Console.WriteLine("Menu Options:");
            Console.WriteLine("  1. Start Breathing Activity");
            Console.WriteLine("  2. Start Reflection Activity");
            Console.WriteLine("  3. Start Listing Activity");
            Console.WriteLine("  4. Start Gratitude Activity");
            Console.WriteLine("  5. Quit");
            Console.Write("Select a choise from the menu: ");
            
            string choice = Console.ReadLine();
            
            //Activity activity = null;
            
            switch (choice)
            {
                case "1":
                    Console.WriteLine($"tu elegistes: {choice}");
                    //activity = new BreathingActivity();
                    break;
                case "2":
                    Console.WriteLine($"tu elegistes: {choice}");
                    //activity = new ReflectionActivity();
                    break;
                case "3":
                    Console.WriteLine($"tu elegistes: {choice}");
                    //activity = new ListingActivity();
                    break;
                case "4":
                    Console.WriteLine($"tu elegistes: {choice}");
                    //activity = new GratitudeActivity();
                    break;
                case "5":
                    running = false;
                    continue;
                default:
                    Console.WriteLine("Invalid choice. Press enter to continue...");
                    Console.ReadLine();
                    continue;
            }
            /*
            if (activity != null)
            {
                activity.RunActivity();
            }
            */
        }
    }
}