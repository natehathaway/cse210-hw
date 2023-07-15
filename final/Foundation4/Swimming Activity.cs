using System;
using System.Collections.Generic;

// Swimming class
public class Swimming : Activity
{
    private int laps;

    public Swimming(DateTime date, int durationInMinutes, int laps)
        : base(date, durationInMinutes)
    {
        this.laps = laps;
    }

    public override double GetDistance()
    {
        return laps * 50 / 1000.0;
    }

    public override double GetSpeed()
    {
        double distanceInKm = GetDistance();
        return (distanceInKm / durationInMinutes) * 60;
    }

    public override double GetPace()
    {
        double distanceInKm = GetDistance();
        return durationInMinutes / distanceInKm;
    }
}
