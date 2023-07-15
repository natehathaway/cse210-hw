using System;
using System.Collections.Generic;
using System.IO;

// Simple goal class
public class SimpleGoal : Goal
{
    public SimpleGoal(string name, int value)
    {
        this.name = name;
        this.value = value;
    }

    public override void RecordEvent()
    {
        Console.WriteLine($"Congratulations! You have completed the {name} goal and earned {value} points.");
    }

    public override bool IsComplete()
    {
        return true;
    }

    public override string GetProgress()
    {
        return "Completed";
    }

    public override int GetScore()
    {
        return value;
    }
}
