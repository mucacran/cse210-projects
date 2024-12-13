// Goal.cs
using System;

public abstract class Goal
{
    protected string _name;
    protected string _description;
    protected int _points;

    public Goal(string name, string description, int points)
    {
        _name = name;
        _description = description;
        _points = points;
    }

    public abstract bool IsComplete();
    public abstract int RecordEvent();
    public virtual string GetStatus()
    {
        return $"{_name} ({_description})";
    }

    public virtual string ToCSV()
    {
        // Format: Type:Name,Description,Points
        return $"{GetType().Name}:{_name},{_description},{_points}";
    }

    public virtual void FromCSV(string data)
    {
        string[] parts = data.Split(',');
        _name = parts[0];
        _description = parts[1];
        _points = int.Parse(parts[2]);
    }
}
