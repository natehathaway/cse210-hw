using System;



// Main program
public class Program
{
    public static void Main(string[] args)
    {
        // Create events
        Address address1 = new Address("123 Main St", "CityA", "StateA");
        Address address2 = new Address("456 Elm St", "CityB", "StateB");

        Lecture lecture = new Lecture("Lecture 1", "This is a lecture.", DateTime.Today, DateTime.Now, address1, "Speaker A", 100);
        Reception reception = new Reception("Reception 1", "This is a reception.", DateTime.Now.Date, DateTime.Now, address2, "rsvp@example.com");
        OutdoorGathering outdoorGathering = new OutdoorGathering("Outdoor Gathering 1", "This is an outdoor gathering.", DateTime.Now.Date, DateTime.Now, address2, "Sunny");

        // Display event messages
        Console.WriteLine("Lecture:");
        Console.WriteLine("Standard Details:\n" + lecture.GenerateStandardDetails());
        Console.WriteLine("\nFull Details:\n" + lecture.GenerateFullDetails());
        Console.WriteLine("\nShort Description:\n" + lecture.GenerateShortDescription());

        Console.WriteLine("\n\nReception:");
        Console.WriteLine("Standard Details:\n" + reception.GenerateStandardDetails());
        Console.WriteLine("\nFull Details:\n" + reception.GenerateFullDetails());
        Console.WriteLine("\nShort Description:\n" + reception.GenerateShortDescription());

        Console.WriteLine("\n\nOutdoor Gathering:");
        Console.WriteLine("Standard Details:\n" + outdoorGathering.GenerateStandardDetails());
        Console.WriteLine("\nFull Details:\n" + outdoorGathering.GenerateFullDetails());
        Console.WriteLine("\nShort Description:\n" + outdoorGathering.GenerateShortDescription());
    }
}
