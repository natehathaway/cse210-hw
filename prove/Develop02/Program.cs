using System;
using System.Collections.Generic;

namespace Develop02
{

    class Program
    {
        static void Main(string[] args)
        {
            // add some test data
            Entry myEntry = new Entry();
            myEntry.StorePrompt("What is your name?");
            myEntry.StoreResponse("Nate Hathaway");
            myEntry.StoreDate("8 May 2023");    

            // create a journal to test
            Journal myJournal = new Journal();
            myJournal.StoreEntry(myEntry);

            // show the journal contents
            List<Entry> entries = myJournal.GetEntries();
            foreach (Entry entry in entries)
            {
                string message 
                    = $"{entry.GetDate()}\n{entry.GetPrompt()}\n{entry.GetResponse()}\n";
                Console.WriteLine(message);

            }



        }
    }
}