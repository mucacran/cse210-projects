using System;

public class Activity
{
    private string _date;
    private int _minutes;

    public Activity(string date, int minutes)
    {
        _date = date;
        _minutes = minutes;
    }

    public int GetMinutes()
    {
        return _minutes;
    }

    public string GetDate()
    {
        return _date;
    }

    public virtual double GetDistance() 
    {
        return 0;
    }

    public virtual double GetSpeed() 
    {
        return 0;
    }

    public virtual double GetPace()
    {
        double distance = GetDistance();
        if (distance == 0) return 0;
        return (double)_minutes / distance;
    }

    public virtual string GetSummary()
    {
        return $"{_date} Activity ({_minutes} min): Dist={GetDistance():F2}, Speed={GetSpeed():F2}, Pace={GetPace():F2}";
    }
}
