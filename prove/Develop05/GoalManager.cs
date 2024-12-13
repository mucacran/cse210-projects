// GoalManager.cs
using System;
using System.Collections.Generic;
using System.IO;

public class GoalManager
{
    private List<Goal> _goals;
    private int _totalPoints;
    private int _level;

    public GoalManager()
    {
        _goals = new List<Goal>();
        _totalPoints = 0;
        _level = 1;
    }

    public void AddGoal(Goal goal)
    {
        _goals.Add(goal);
    }

    public void DisplayGoals()
    {
        Console.WriteLine("Your Goals:");
        if (_goals.Count == 0)
        {
            Console.WriteLine("No goals to display.");
        }
        else
        {
            int i = 1;
            foreach (var g in _goals)
            {
                Console.WriteLine($"{i}. {g.GetStatus()}");
                i++;
            }
        }
        Console.WriteLine($"Total Points: {_totalPoints}");
        Console.WriteLine($"Level: {_level}");
    }

    public void RecordEventOnGoal(int goalIndex)
    {
        if (goalIndex < 1 || goalIndex > _goals.Count)
        {
            Console.WriteLine("Invalid goal number.");
            return;
        }

        Goal g = _goals[goalIndex - 1];
        int earned = g.RecordEvent();
        if (earned > 0)
        {
            _totalPoints += earned;
            Console.WriteLine($"Congratulations! You earned {earned} points.");
            LevelUpCheck();

            // Check if ChecklistGoal just completed
            if (g is ChecklistGoal cg && cg.IsComplete())
            {
                Console.WriteLine("***************************");
                Console.WriteLine("**  Checklist Completed! **");
                Console.WriteLine("***************************");
            }
        }
        else
        {
            Console.WriteLine("This goal is already completed or no points were awarded.");
        }
    }

    private void LevelUpCheck()
    {
        // Every 500 points = next level
        int nextLevelThreshold = _level * 500;
        while (_totalPoints >= nextLevelThreshold)
        {
            _level++;
            Console.WriteLine($"*** Level Up! You are now Level {_level}! ***");
            nextLevelThreshold = _level * 500;
        }
    }

    public int GetTotalPoints()
    {
        return _totalPoints;
    }

    public int GetLevel()
    {
        return _level;
    }

    public void SaveGoals(string filename)
    {
        using (StreamWriter output = new StreamWriter(filename))
        {
            // First line: total points
            output.WriteLine(_totalPoints);
            // Second line: level
            output.WriteLine(_level);

            foreach (var g in _goals)
            {
                output.WriteLine(g.ToCSV());
            }
        }
        Console.WriteLine("Goals saved successfully!");
    }

    public void LoadGoals(string filename)
    {
        if (!File.Exists(filename))
        {
            Console.WriteLine("File not found.");
            return;
        }

        string[] lines = File.ReadAllLines(filename);
        if (lines.Length < 2)
        {
            Console.WriteLine("Not enough data in file.");
            return;
        }

        _totalPoints = int.Parse(lines[0]);
        _level = int.Parse(lines[1]);

        _goals.Clear();
        for (int i = 2; i < lines.Length; i++)
        {
            string line = lines[i];
            string[] firstSplit = line.Split(':');
            string typeName = firstSplit[0];
            string data = firstSplit[1];

            Goal g = null;
            switch (typeName)
            {
                case "SimpleGoal":
                    g = new SimpleGoal("temp", "temp", 0);
                    break;
                case "EternalGoal":
                    g = new EternalGoal("temp", "temp", 0);
                    break;
                case "ChecklistGoal":
                    g = new ChecklistGoal("temp", "temp", 0, 1, 0);
                    break;
            }
            if (g != null)
            {
                g.FromCSV(data);
                _goals.Add(g);
            }
        }
        Console.WriteLine("Goals loaded successfully!");
    }
}
