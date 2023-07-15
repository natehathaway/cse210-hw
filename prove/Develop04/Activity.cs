using System;
using System.Threading;


// Parent class
public abstract class Activity
{
    protected string activityName;
    protected string description;
    protected int duration;

    public void StartActivity()
    {
        Console.WriteLine($"\n{activityName}\n");
        Console.WriteLine(description);
        duration = GetDuration();
        Console.WriteLine("\nPrepare to begin...");
        Thread.Sleep(3000);
        PerformActivity();
        EndActivity();
    }

    protected int GetDuration()
    {
        Console.Write("Enter the duration in seconds: ");
        int duration;
        while (!int.TryParse(Console.ReadLine(), out duration) || duration <= 0)
        {
            Console.WriteLine("Invalid duration. Please enter a positive integer.");
        }
        return duration;
    }

    protected void EndActivity()
    {
        Console.WriteLine("\nGood job!");
        Console.WriteLine($"You have completed the {activityName} for {duration} seconds.");
        Thread.Sleep(3000);
    }

    protected abstract void PerformActivity();
}
