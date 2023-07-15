using System;
using System.Collections.Generic;

// Running class
public class Running : Activity
{
    private double distance;

    public Running(DateTime date, int durationInMinutes, double distance)
        : base(date, durationInMinutes)
    {
        this.distance = distance;
    }

    public override double GetDistance()
    {
        return distance;
    }

    public override double GetSpeed()
    {
        return (distance / durationInMinutes) * 60;
    }

    public override double GetPace()
    {
        return durationInMinutes / distance;
    }
}