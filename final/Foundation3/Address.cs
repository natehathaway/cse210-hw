using System;

// Address class
public class Address
{
    private string street;
    private string city;
    private string state;

    public string Street { get { return street; } }
    public string City { get { return city; } }
    public string State { get { return state; } }

    public Address(string street, string city, string state)
    {
        this.street = street;
        this.city = city;
        this.state = state;
    }
}