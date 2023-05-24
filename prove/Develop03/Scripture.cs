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
            foreach (string word in _words)
            {
                int randomNum = random.Next(0, 3);
                if (isHidden == false)
                {
                    if (randomNum == 0)
                    {
                        Word.Hide(word);
                    }
                    else
                    {
                        Word.Show(word);
                    }
                }
                else
                {
                    Word.Show(word);
                }

            }
        }


        public void GetRenderedText(List<string> _words)
        {
            foreach (string word in _words)
            {
                Word.GetRenderedText(word);
            }
        }


        public void IsCompletelyHidden(List<string> _words)
        {
            bool isHidden = true;
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
            if (isHidden == true)
            {
            Console.WriteLine("Thank you for using my program!");
            Console.WriteLine("press any key to exit.");
            Console.ReadKey();
        
            }
        }
    }
}