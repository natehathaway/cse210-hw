using System;
using System.Collections.Generic;

// Cycling class
public class Cycling : Activity
{
    private double speed;

    public Cycling(DateTime date, int durationInMinutes, double speed)
        : base(date, durationInMinutes)
    {
        this.speed = speed;
    }

    public override double GetDistance()
    {
        return (speed / 60) * durationInMinutes;
    }

    public override double GetSpeed()
    {
        return speed;
    }

    public override double GetPace()
    {
        return 60 / speed;
    }
}