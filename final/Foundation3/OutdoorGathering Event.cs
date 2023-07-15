using System;

// OutdoorGathering class
public class OutdoorGathering : Event
{
    private string weatherForecast;

    public OutdoorGathering(string title, string description, DateTime date, DateTime time, Address address, string weatherForecast)
        : base(title, description, date, time, address)
    {
        this.weatherForecast = weatherForecast;
    }

    public override string GenerateStandardDetails()
    {
        return $"Title: {title}\nDescription: {description}\nDate: {date.ToShortDateString()}\nTime: {time.ToShortTimeString()}\nAddress: {address.Street}, {address.City}, {address.State}";
    }

    public override string GenerateFullDetails()
    {
        return $"{GenerateStandardDetails()}\nType: Outdoor Gathering\nWeather Forecast: {weatherForecast}";
    }

    public override string GenerateShortDescription()
    {
        return $"Type: Outdoor Gathering\nTitle: {title}\nDate: {date.ToShortDateString()}";
    }
}
