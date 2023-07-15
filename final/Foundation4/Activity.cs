using System;
using System.Collections.Generic;

// Base Activity class
public abstract class Activity
{
    protected DateTime date;
    protected int durationInMinutes;

    public Activity(DateTime date, int durationInMinutes)
    {
        this.date = date;
        this.durationInMinutes = durationInMinutes;
    }

    public abstract double GetDistance();

    public abstract double GetSpeed();

    public abstract double GetPace();

    public string GetSummary()
    {
        string activityType = GetType().Name;
        double distance = GetDistance();
        double speed = GetSpeed();
        double pace = GetPace();

        string unit = activityType == "Swimming" ? "km" : "miles";
        string speedUnit = activityType == "Swimming" ? "kph" : "mph";
        string paceUnit = activityType == "Swimming" ? "min per km" : "min per mile";

        return $"{date.ToShortDateString()} {activityType} ({durationInMinutes} min) - Distance: {distance:F1} {unit}, Speed: {speed:F1} {speedUnit}, Pace: {pace:F1} {paceUnit}";
    }
}