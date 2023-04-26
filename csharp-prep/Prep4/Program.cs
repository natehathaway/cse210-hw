using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main(string[] args)
    
    {
        Console.WriteLine("Enter a list of numbers, type 0 when finished.");
        List<int> numbers = new List<int>();
        do
            numbers.Add(int.Parse(Console.ReadLine()));
        while (numbers[numbers.Count - 1] != 0);
        numbers.RemoveAt(numbers.Count - 1);
        Console.WriteLine($"The sum of the numbers is {numbers.Sum()} ");
        Console.WriteLine($"The average of the numbers is {numbers.Average()} ");
        Console.WriteLine($"The largest number is {numbers.Max()} ");
    }
}