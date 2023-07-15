using System;

// Reception class
public class Reception : Event
{
    private string rsvpEmail;

    public Reception(string title, string description, DateTime date, DateTime time, Address address, string rsvpEmail)
        : base(title, description, date, time, address)
    {
        this.rsvpEmail = rsvpEmail;
    }

    public override string GenerateStandardDetails()
    {
        return $"Title: {title}\nDescription: {description}\nDate: {date.ToShortDateString()}\nTime: {time.ToShortTimeString()}\nAddress: {address.Street}, {address.City}, {address.State}";
    }

    public override string GenerateFullDetails()
    {
        return $"{GenerateStandardDetails()}\nType: Reception\nRSVP Email: {rsvpEmail}";
    }

    public override string GenerateShortDescription()
    {
        return $"Type: Reception\nTitle: {title}\nDate: {date.ToShortDateString()}";
    }
}
