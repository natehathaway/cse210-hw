using System;
using System.Collections.Generic;

namespace Develop03
{
    //To hold a scripture and its reference, can hide words and display them.
    public class Scripture
    {
        private List<Word> _words;
        private Reference _reference;

        public void HideWords(List<Word> _words)
        {
            foreach (Word word in _words)
            {
                Random random = new Random();
                int randomNum = random.Next(0, 5);
                if (isHidden == false)
                {
                    if (randomNum == 0)
                    {
                        word.Hide();
                    }
                    else
                    {
                        word.Show();
                    }
                }
                else
                {
                    word.Show();
                }

            }
        }


        public void GetRenderedText(List<Word> _words)
        {
            foreach (Word word in _words)
            {
                word.GetRenderedText();
            }
        }
    }
}