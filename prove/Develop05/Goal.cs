using System;
using System.Collections.Generic;
using System.IO;

// Base class for goals
public abstract class Goal
{
    protected string name;
    protected int value;

    public string Name { get { return name; } }

    public abstract void RecordEvent();

    public abstract bool IsComplete();

    public abstract string GetProgress();

    public abstract int GetScore();
}
