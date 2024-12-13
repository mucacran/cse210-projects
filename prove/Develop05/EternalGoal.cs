// EternalGoal.cs
using System;

public class EternalGoal : Goal
{
    public EternalGoal(string name, string description, int points)
        : base(name, description, points)
    {
    }

    public override bool IsComplete()
    {
        return false; // Nunca se completa
    }

    public override int RecordEvent()
    {
        // Siempre se obtienen puntos cada vez que se registra
        return _points;
    }

    public override string GetStatus()
    {
        return $"[ ] {_name} ({_description})";
    }

    public override string ToCSV()
    {
        return $"{GetType().Name}:{_name},{_description},{_points}";
    }

    public override void FromCSV(string data)
    {
        // Name,Description,Points
        string[] parts = data.Split(',');
        _name = parts[0];
        _description = parts[1];
        _points = int.Parse(parts[2]);
    }
}
