using System;
using System.Collections.Generic;
using System.Linq;
//Functions to create:
//DisplayWelcome - Displays the message, "Welcome to the Program!"
//PromptUserName - Asks for and returns the user's name (as a string)
//PromptUserNumber - Asks for and returns the user's favorite number (as an integer)
//SquareNumber - Accepts an integer as a parameter and returns that number squared (as an integer)
//DisplayResult - Accepts the user's name and the squared number and displays them.
class Program
{
    static void Main(string[] args)
    {
        static void DisplayWelcome()
        {
            Console.WriteLine("Welcome to the Program!");
        }
        static string PromptUserName()
        {
            Console.WriteLine("What is your name?");
            string name = Console.ReadLine();
            return name;
        }
        static int PromptUserNumber()
        {
            Console.WriteLine("What is your favorite number?");
            int number = int.Parse(Console.ReadLine());
            return number;
        }
        static int squaredNumber(int number)
        {
            int squaredNumber = number * number;
            return squaredNumber;
        }
        static void DisplayResult(string name, int squaredNumber)
        {
            Console.WriteLine("Hello " + name + ", your favorite number squared is " + squaredNumber);
            
        }
        DisplayWelcome();
        string name = PromptUserName();
        int number = PromptUserNumber();
        int squared = squaredNumber(number);
        DisplayResult(name, squared);
    }
}