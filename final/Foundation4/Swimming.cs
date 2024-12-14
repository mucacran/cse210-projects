using System;

public class Swimming : Activity
{
    private int _laps;
    // Asumiendo 1 lap = 50m. Suponiendo conversión a millas
    // 1 lap (50m) = 0.05 km = 0.031 mi (aprox. 50/1000*0.62 ≈ 0.031)
    // Tomaremos la conversión a millas: distance = laps * 0.031

    public Swimming(string date, int minutes, int laps)
        : base(date, minutes)
    {
        _laps = laps;
    }

    public override double GetDistance()
    {
        return _laps * 0.031; 
    }

    public override double GetSpeed()
    {
        // speed = distance/(min/60)
        return GetDistance() / (GetMinutes() / 60.0);
    }

    public override double GetPace()
    {
        double distance = GetDistance();
        if (distance == 0) return 0;
        return (double)GetMinutes() / distance;
    }

    public override string GetSummary()
    {
        return $"{GetDate()} Swimming ({GetMinutes()} min): Dist={GetDistance():F2} mi, Speed={GetSpeed():F2} mph, Pace={GetPace():F2} min/mi";
    }
}
