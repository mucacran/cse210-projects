// Program.cs
// Exceeds Requirements: Implemented a leveling system where the user levels up every 500 points.
// Additionally, shows a special message when a checklist goal is completed.

using System;

public class Program
{
    public static void Main()
    {
        GoalManager manager = new GoalManager();
        bool quit = false;
        while (!quit)
        {
            Console.WriteLine();
            Console.WriteLine($"You have {manager.GetTotalPoints()} points. Level: {manager.GetLevel()}");
            Console.WriteLine("Menu Options:");
            Console.WriteLine("1. Create New Goal");
            Console.WriteLine("2. List Goals");
            Console.WriteLine("3. Save Goals");
            Console.WriteLine("4. Load Goals");
            Console.WriteLine("5. Record Event");
            Console.WriteLine("6. Quit");
            Console.Write("Select a choice from the menu: ");
            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    CreateGoal(manager);
                    break;
                case "2":
                    manager.DisplayGoals();
                    break;
                case "3":
                    Console.Write("Enter filename to save: ");
                    string saveFile = Console.ReadLine();
                    manager.SaveGoals(saveFile);
                    break;
                case "4":
                    Console.Write("Enter filename to load: ");
                    string loadFile = Console.ReadLine();
                    manager.LoadGoals(loadFile);
                    break;
                case "5":
                    manager.DisplayGoals();
                    Console.Write("Which goal did you accomplish? ");
                    string goalNumStr = Console.ReadLine();
                    if (int.TryParse(goalNumStr, out int goalNum))
                    {
                        manager.RecordEventOnGoal(goalNum);
                    }
                    else
                    {
                        Console.WriteLine("Invalid input.");
                    }
                    break;
                case "6":
                    quit = true;
                    break;
                default:
                    Console.WriteLine("Invalid choice.");
                    break;
            }
        }

        Console.WriteLine("Goodbye!");
    }

    private static void CreateGoal(GoalManager manager)
    {
        Console.WriteLine("The types of Goals are:");
        Console.WriteLine("1. Simple Goal");
        Console.WriteLine("2. Eternal Goal");
        Console.WriteLine("3. Checklist Goal");
        Console.Write("Which type of goal would you like to create? ");
        string typeChoice = Console.ReadLine();

        Console.Write("What is the name of your goal? ");
        string name = Console.ReadLine();
        Console.Write("What is a short description of it? ");
        string description = Console.ReadLine();
        Console.Write("What is the amount of points associated with this goal? ");
        int points = int.Parse(Console.ReadLine());

        Goal newGoal = null;

        switch (typeChoice)
        {
            case "1":
                // Simple Goal
                newGoal = new SimpleGoal(name, description, points);
                break;
            case "2":
                // Eternal Goal
                newGoal = new EternalGoal(name, description, points);
                break;
            case "3":
                // Checklist Goal
                Console.Write("How many times does this goal need to be accomplished for a bonus? ");
                int targetCount = int.Parse(Console.ReadLine());
                Console.Write("What is the bonus for completing it that many times? ");
                int bonusPoints = int.Parse(Console.ReadLine());
                newGoal = new ChecklistGoal(name, description, points, targetCount, bonusPoints);
                break;
            default:
                Console.WriteLine("Invalid type choice. Goal not created.");
                return;
        }

        manager.AddGoal(newGoal);
        Console.WriteLine("Goal created successfully!");
    }
}
