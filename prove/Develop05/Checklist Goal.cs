using System;
using System.Collections.Generic;
using System.IO;

// Checklist goal class
public class ChecklistGoal : Goal
{
    private int targetCount;
    private int currentCount;

    public ChecklistGoal(string name, int value, int targetCount)
    {
        this.name = name;
        this.value = value;
        this.targetCount = targetCount;
        this.currentCount = 0;
    }

    public override void RecordEvent()
    {
        currentCount++;
        Console.WriteLine($"Congratulations! You have completed the {name} goal {currentCount}/{targetCount} times and earned {value} points.");
        if (currentCount == targetCount)
        {
            Console.WriteLine($"You have achieved the target count for the {name} goal and earned a bonus of {value} points.");
            value += value;
        }
    }

    public override bool IsComplete()
    {
        return currentCount >= targetCount;
    }

    public override string GetProgress()
    {
        return $"Completed {currentCount}/{targetCount} times";
    }

    public override int GetScore()
    {
        return value;
    }
}