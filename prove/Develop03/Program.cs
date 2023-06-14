using System;
using System.Collections.Generic;
namespace Develop03
{
public class Program
{
    public static void Main()
    {
        Scripture scripture = new Scripture("John 3:16", "For God so loved the world, that he gave his only begotten Son, that whosoever believeth in him should not perish, but have everlasting life.");
        HideWordsInScripture(scripture);
    }

    public static void HideWordsInScripture(Scripture scripture)
    {
        Console.Clear();
        Console.WriteLine(scripture.GetFormattedScripture());

        while (!scripture.AllWordsHidden)
        {
            Console.WriteLine("Press Enter to continue or type 'quit' to exit.");
            string input = Console.ReadLine().ToLower();

            if (input == "quit")
                break;

            scripture.HideRandomWord();
            Console.Clear();
            Console.WriteLine(scripture.GetFormattedScripture());
        }
    }
}}
