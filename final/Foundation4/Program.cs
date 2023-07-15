using System;
using System.Collections.Generic;

// Main program
public class Program
{
    public static void Main(string[] args)
    {
        // Create activities
        List<Activity> activities = new List<Activity>();

        DateTime date = DateTime.Today;
        int durationInMinutes = 30;
        double runningDistance = 3.0;
        double cyclingSpeed = 15.0;
        int swimmingLaps = 10;

        Activity running = new Running(date, durationInMinutes, runningDistance);
        Activity cycling = new Cycling(date, durationInMinutes, cyclingSpeed);
        Activity swimming = new Swimming(date, durationInMinutes, swimmingLaps);

        activities.Add(running);
        activities.Add(cycling);
        activities.Add(swimming);

        // Display summaries
        foreach (Activity activity in activities)
        {
            Console.WriteLine(activity.GetSummary());
        }
    }
}
