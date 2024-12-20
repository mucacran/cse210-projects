using System;

public class Running : Activity
{
    private double _distance; // Ej: en millas

    public Running(string date, int minutes, double distance) : base(date, minutes)
    {
        _distance = distance;
    }

    public override double GetDistance()
    {
        return _distance; 
    }

    public override double GetSpeed()
    {
        // speed = distance / (min/60) = distance * (60/min)
        return (GetDistance() / (GetMinutes() / 60.0));
    }

    public override double GetPace()
    {
        // pace = min/distance
        return (double)GetMinutes() / GetDistance();
    }

    public override string GetSummary()
    {
        return $"{GetDate()} Running ({GetMinutes()} min): Dist={GetDistance():F2} mi, Speed={GetSpeed():F2} mph, Pace={GetPace():F2} min/mi";
    }
}
