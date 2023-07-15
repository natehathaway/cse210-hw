using System;
using System.Collections.Generic;
using System.IO;

// Goal tracker class
public class GoalTracker
{
    private List<Goal> goals;
    private int totalScore;

    public GoalTracker()
    {
        goals = new List<Goal>();
        totalScore = 0;
    }

    public void AddGoal(Goal goal)
    {
        goals.Add(goal);
        Console.WriteLine($"The {goal.Name} goal has been added.");
    }

    public void RecordEvent(int goalIndex)
    {
        if (goalIndex >= 0 && goalIndex < goals.Count)
        {
            Goal goal = goals[goalIndex];
            goal.RecordEvent();
            totalScore += goal.GetScore();
        }
        else
        {
            Console.WriteLine("Invalid goal index.");
        }
    }

    public void DisplayGoals()
    {
        Console.WriteLine("\nGoals:");

        for (int i = 0; i < goals.Count; i++)
        {
            Goal goal = goals[i];
            string progress = goal.GetProgress();
            string status = goal.IsComplete() ? "[X]" : "[ ]";
            Console.WriteLine($"{i + 1}. {status} {goal.Name} - {progress}");
        }

        Console.WriteLine($"\nTotal Score: {totalScore}");
    }

    public void SaveGoals(string fileName)
    {
        using (StreamWriter writer = new StreamWriter(fileName))
        {
            foreach (Goal goal in goals)
            {
                writer.WriteLine($"{goal.GetType().Name},{goal.Name},{goal.GetProgress()},{goal.GetScore()}");
            }
        }
        Console.WriteLine("Goals have been saved.");
    }

    public void LoadGoals(string fileName)
    {
        if (File.Exists(fileName))
        {
            goals.Clear();

            using (StreamReader reader = new StreamReader(fileName))
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    string[] parts = line.Split(',');
                    if (parts.Length == 4)
                    {
                        string goalType = parts[0];
                        string name = parts[1];
                        string progress = parts[2];
                        int score = int.Parse(parts[3]);

                        Goal goal;

                        switch (goalType)
                        {
                            case "SimpleGoal":
                                goal = new SimpleGoal(name, score);
                                break;
                            case "EternalGoal":
                                goal = new EternalGoal(name, score);
                                break;
                            case "ChecklistGoal":
                                goal = new ChecklistGoal(name, score, 5); // Assuming a fixed target count of 5 for checklist goals
                                break;
                            default:
                                continue;
                        }

                        goals.Add(goal);
                    }
                }
            }
            Console.WriteLine("Goals have been loaded.");
        }
        else
        {
            Console.WriteLine("Goals file does not exist.");
        }
    }
}
