using System;
using System.Collections.Generic;

namespace Develop03
{
    //To hold a scripture and its reference, can hide words and display them.
    public class Scripture
    {
        private string _verse;
        private List<string> _words;
        private Reference _reference;

        public Scripture(string _verse, List<string> _words, Reference _reference)
        {
            this._verse = _verse;
            this._words = _words;
            this._reference = _reference;
            List<string> words = new List<string>();
            words = new List<string>(_verse.Split(' '));
        }

        

        public void HideWords(List<string> _words)
        {
            Random random = new Random();
            
            bool isHidden = Word.IsHidden;
            isHidden = false;
            for(int i = 0; i < _words.Count; i++)
            // foreach (string word in _words)
            {
                int randomNum = random.Next(0, 3);
                if (isHidden == false)
                {//fix here
                    if (randomNum == 0)
                    {
                        Word.Hide(_words[i]);
                    }
                    else
                    {
                        Word.Show(_words[i]);
                    }
                }
                else
                {
                    Word.Show(_words[i]);
                }

            }
        }


        public void DisplayText(List<string> _words)
        {
            //This function takes the list of words and displays them in a line
            foreach (string word in _words)
            {
                Console.Write(word + " ");
            }

        }


        public void IsCompletelyHidden(List<string> _words)
        {
            bool isHidden = Word.IsHidden;
            foreach (string word in _words)
            {
                if (Word.IsHidden == false)
                {
                    isHidden = false;
                }
                if (Word.IsHidden == true)
                {
                    isHidden = true;
                }
            }
        }
    }
}
