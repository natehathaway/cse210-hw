using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("What is your grade percentage?");
        string gradePercentage = Console.ReadLine();
        int gradePercentageInt = int.Parse(gradePercentage);
        string letterGrade = "";
        if (gradePercentageInt >= 90)
        {
            letterGrade = "A";
        }
        else if (gradePercentageInt >= 80)
        {
            letterGrade = "B";
        }
        else if (gradePercentageInt >= 70)
        {
            letterGrade = "C";
        }
        else if (gradePercentageInt >= 60)
        {
            letterGrade = "D";
        }
        else
        {
            letterGrade = "F";
        }
        Console.WriteLine($"Your grade is {letterGrade}." );
        if (gradePercentageInt >= 70)
        {
            Console.WriteLine("You passed, congratulations!");
        }
        else
        {
            Console.WriteLine("You failed! Better luck next time!");
        }
    }
}