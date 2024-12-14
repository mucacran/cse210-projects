using System;

public class Cycling : Activity
{
    private double _speed; // por ejemplo mph

    public Cycling(string date, int minutes, double speed)
        : base(date, minutes)
    {
        _speed = speed;
    }

    public override double GetDistance()
    {
        // distance = speed * hours (min/60)
        return _speed * (GetMinutes() / 60.0);
    }

    public override double GetSpeed()
    {
        return _speed;
    }

    public override double GetPace()
    {
        double distance = GetDistance();
        if (distance == 0) return 0;
        // pace = min/distance
        return (double)GetMinutes() / distance;
    }

    public override string GetSummary()
    {
        return $"{GetDate()} Cycling ({GetMinutes()} min): Dist={GetDistance():F2} mi, Speed={GetSpeed():F2} mph, Pace={GetPace():F2} min/mi";
    }
}
