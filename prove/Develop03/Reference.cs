using System;

namespace Develop03
{
    //Keeps track of the book, chapter, and verse information for a scripture
    public class Reference
    {
        private string _bookName;
        private int _chapter;
        private int _verse;
        private int _endVerse;

        public string FormatReference(string _bookName, int _chapter, int _verse, int _endVerse)
        {
            string reference = _bookName + " " + _chapter + ":" + _verse;
            if (_endVerse != 0)
            {
                reference += "-" + _endVerse;
            }
            return reference;
        }
    }
}