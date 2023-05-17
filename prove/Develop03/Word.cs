using System;

namespace Develop03
{
    //Keep trach of a word, whether it is shown or hidden
    public class Word
    {
        private bool _isHidden;
        private string _word;



        public Hide(string _word)
        {
            _isHidden = true;
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

        }
    }
}