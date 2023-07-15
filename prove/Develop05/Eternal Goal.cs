using System;
using System.Collections.Generic;
using System.IO;

// Eternal goal class
public class EternalGoal : Goal
{
    public EternalGoal(string name, int value)
    {
        this.name = name;
        this.value = value;
    }

    public override void RecordEvent()
    {
        Console.WriteLine($"You have recorded progress for the {name} goal and earned {value} points.");
    }

    public override bool IsComplete()
    {
        return false;
    }

    public override string GetProgress()
    {
        return "Ongoing";
    }

    public override int GetScore()
    {
        return value;
    }
}
