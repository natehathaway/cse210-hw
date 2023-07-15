using System;

// Base Event class
public abstract class Event
{
    protected string title;
    protected string description;
    protected DateTime date;
    protected DateTime time;
    protected Address address;

    public Event(string title, string description, DateTime date, DateTime time, Address address)
    {
        this.title = title;
        this.description = description;
        this.date = date;
        this.time = time;
        this.address = address;
    }

    public abstract string GenerateStandardDetails();

    public abstract string GenerateFullDetails();

    public abstract string GenerateShortDescription();
}
