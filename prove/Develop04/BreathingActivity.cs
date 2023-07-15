using System;
using System.Threading;



// Child class for the Breathing activity
public class BreathingActivity : Activity
{
    public BreathingActivity()
    {
        activityName = "Breathing Activity";
        description = "This activity will help you relax by walking you through breathing in and out slowly. Clear your mind and focus on your breathing.";
    }

    protected override void PerformActivity()
    {
        for (int i = 0; i < duration; i += 2)
        {
            Console.WriteLine("\nBreathe in...");
            Thread.Sleep(2000);

            Console.WriteLine("Breathe out...");
            Thread.Sleep(2000);
        }
    }
}