using System;

namespace Develop03
{
    //Keep trach of a word, whether it is shown or hidden
    public class Word
    {
        private static bool _isHidden;
        private string _word;

        public static bool IsHidden
        {
            get
            {
                return _isHidden;
            }
        }

        public static string Hide(string _word)
        {
            foreach (char c in _word)
            {
                if (c == ' ')
                {
                    _word += " ";
                }
                else
                {
                    _word += "_";
                }
            }
            _isHidden = true;
            return _word;
        }

        public static string Show(string _word)
        {
            _isHidden = false;
            return _word;
        }

        public static void GetRenderedText(string _word)
        {
            Console.WriteLine(_word);
        }
    }
}