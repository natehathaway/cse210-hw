using System;
using System.Collections.Generic;
using System.IO;


// Main program
public class Program
{
    public static void Main(string[] args)
    {
        GoalTracker goalTracker = new GoalTracker();

        goalTracker.AddGoal(new SimpleGoal("Run a Marathon", 1000));
        goalTracker.AddGoal(new EternalGoal("Read Scriptures", 100));
        goalTracker.AddGoal(new ChecklistGoal("Attend Temple", 50, 10));

        goalTracker.RecordEvent(0);
        goalTracker.RecordEvent(1);
        goalTracker.RecordEvent(2);
        goalTracker.RecordEvent(2);
        goalTracker.RecordEvent(2);
        goalTracker.RecordEvent(2);
        goalTracker.RecordEvent(2);
        goalTracker.RecordEvent(2);
        goalTracker.RecordEvent(2);
        goalTracker.RecordEvent(2);
        goalTracker.RecordEvent(2);

        goalTracker.DisplayGoals();

        goalTracker.SaveGoals("goals.txt");

        goalTracker.LoadGoals("goals.txt");

        goalTracker.DisplayGoals();
    }
}
