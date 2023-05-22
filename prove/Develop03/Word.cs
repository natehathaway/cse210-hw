using System;

namespace Develop03
{
    //Keep trach of a word, whether it is shown or hidden
    public class Word
    {
        private bool _isHidden;
        private string _word;

        public bool IsHidden
        {
            get
            {
                return _isHidden;
            }
        }

        public string Hide(string _word)
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
            IsHidden = true;
            return _word;
        }

        public string Show(string _word)
        {
            _isHidden = false;
            return _word;
        }

        public void GetRenderedText(string _word)
        {
            Console.WriteLine(_word);
        }
    }
}