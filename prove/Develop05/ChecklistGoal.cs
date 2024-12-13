// ChecklistGoal.cs
using System;

public class ChecklistGoal : Goal
{
    private int _timesCompleted;
    private int _targetCount;
    private int _bonusPoints;

    public ChecklistGoal(string name, string description, int points, int targetCount, int bonusPoints)
        : base(name, description, points)
    {
        _targetCount = targetCount;
        _bonusPoints = bonusPoints;
        _timesCompleted = 0;
    }

    public override bool IsComplete()
    {
        return _timesCompleted >= _targetCount;
    }

    public override int RecordEvent()
    {
        _timesCompleted++;
        if (IsComplete())
        {
            return _points + _bonusPoints;
        }
        else
        {
            return _points;
        }
    }

    public override string GetStatus()
    {
        string check = IsComplete() ? "[X]" : "[ ]";
        return $"{check} {_name} ({_description}) -- Completed {_timesCompleted}/{_targetCount}";
    }

    public override string ToCSV()
    {
        // Type:Name,Description,Points,TargetCount,BonusPoints,TimesCompleted
        return $"{GetType().Name}:{_name},{_description},{_points},{_targetCount},{_bonusPoints},{_timesCompleted}";
    }

    public override void FromCSV(string data)
    {
        string[] parts = data.Split(',');
        _name = parts[0];
        _description = parts[1];
        _points = int.Parse(parts[2]);
        _targetCount = int.Parse(parts[3]);
        _bonusPoints = int.Parse(parts[4]);
        _timesCompleted = int.Parse(parts[5]);
    }
}