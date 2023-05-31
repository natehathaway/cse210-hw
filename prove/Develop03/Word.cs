using System;

namespace Develop03
{
    //Keep trach of a word, whether it is shown or hidden
    public class Word
    {
        private static bool _isHidden;
        private string _word;
        private string _hiddenWord;

        public static bool IsHidden
        {
            get
            {
                return _isHidden;
            }
        }

        public static string Hide(string _word, bool _isHidden, string _hiddenWord)
        {
            //the purpose of Hide is to take the string and replace it with underscores
            _isHidden = true;
            _hiddenWord = "";
            foreach (char letter in _word)
            {
                _hiddenWord += "_";
            }
            // return hiddenWord;
            return _hiddenWord;
        }

        public static string Show(string _word)
        {
            _isHidden = false;
            return _word;
        }
    }
}
