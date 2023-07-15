using System;
using System.Collections.Generic;

// Main program
public class Program
{
    public static void Main(string[] args)
    {
        // Create address
        Address address1 = new Address("123 Main St", "CityA", "StateA", "USA");
        Address address2 = new Address("456 Elm St", "CityB", "StateB", "Canada");

        // Create customers
        Customer customer1 = new Customer("CustomerA", address1);
        Customer customer2 = new Customer("CustomerB", address2);

        // Create products
        Product product1 = new Product("Product1", "P1", 10.0m, 2);
        Product product2 = new Product("Product2", "P2", 5.0m, 3);
        Product product3 = new Product("Product3", "P3", 8.0m, 1);

        // Create orders
        Order order1 = new Order(new List<Product> { product1, product2 }, customer1);
        Order order2 = new Order(new List<Product> { product2, product3 }, customer2);

        // Display results
        Console.WriteLine("Order 1");
        Console.WriteLine("Total Cost: $" + order1.CalculateTotalCost());
        Console.WriteLine(order1.GetPackingLabel());
        Console.WriteLine(order1.GetShippingLabel());

        Console.WriteLine();

        Console.WriteLine("Order 2");
        Console.WriteLine("Total Cost: $" + order2.CalculateTotalCost());
        Console.WriteLine(order2.GetPackingLabel());
        Console.WriteLine(order2.GetShippingLabel());
    }
}
