using System;

// Lecture class
public class Lecture : Event
{
    private string speaker;
    private int capacity;

    public Lecture(string title, string description, DateTime date, DateTime time, Address address, string speaker, int capacity)
        : base(title, description, date, time, address)
    {
        this.speaker = speaker;
        this.capacity = capacity;
    }

    public override string GenerateStandardDetails()
    {
        return $"Title: {title}\nDescription: {description}\nDate: {date.ToShortDateString()}\nTime: {time.ToShortTimeString()}\nAddress: {address.Street}, {address.City}, {address.State}";
    }

    public override string GenerateFullDetails()
    {
        return $"{GenerateStandardDetails()}\nType: Lecture\nSpeaker: {speaker}\nCapacity: {capacity}";
    }

    public override string GenerateShortDescription()
    {
        return $"Type: Lecture\nTitle: {title}\nDate: {date.ToShortDateString()}";
    }
}
