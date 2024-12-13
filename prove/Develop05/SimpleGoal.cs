// SimpleGoal.cs
using System;

public class SimpleGoal : Goal
{
    private bool _completed;

    public SimpleGoal(string name, string description, int points)
        : base(name, description, points)
    {
        _completed = false;
    }

    public override bool IsComplete()
    {
        return _completed;
    }

    public override int RecordEvent()
    {
        if (!_completed)
        {
            _completed = true;
            return _points;
        }
        else
        {
            return 0;
        }
    }

    public override string GetStatus()
    {
        string check = _completed ? "[X]" : "[ ]";
        return $"{check} {_name} ({_description})";
    }

    public override string ToCSV()
    {
        // Type:Name,Description,Points,Completed
        return $"{GetType().Name}:{_name},{_description},{_points},{_completed}";
    }

    public override void FromCSV(string data)
    {
        string[] parts = data.Split(',');
        _name = parts[0];
        _description = parts[1];
        _points = int.Parse(parts[2]);
        _completed = bool.Parse(parts[3]);
    }
}
