using System;
using System.Collections.Generic;
namespace Develop03
{
    public class Program
    {
        static void Main(string[] args)
        {
            bool play = true;
            while (play == true)
            {
                Console.WriteLine("Welcome to the Scripture Memory Program!");
                string book = "Moses";
                int chapter = 1;
                int verse = 39;
                int endVerse = 0;
                string verseText = "For behold, this is my work and my glory—to bring to pass the immortality and eternal life of man.";
                Reference reference = new Reference();
                reference.FormatReference(book, chapter, verse, endVerse);
                List<string> words = new List<string>();
                Scripture scripture = new Scripture(verseText, words, reference);
                string user = "";
                while (user !="quit")
                {
                    Console.WriteLine("press enter to hide words.");
                    Console.ReadLine();
                    scripture.HideWords(words);
                    Console.WriteLine(words);
                    scripture.IsCompletelyHidden(words);
                    Console.WriteLine("Type 'quit' to quit or press enter to continue.");
                    user = Console.ReadLine();
                }
                play = false;
        }
    }
}
