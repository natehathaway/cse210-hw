using System;
using System.Collections.Generic;

namespace Develop03
{
    //To hold a scripture and its reference, can hide words and display them.
    public class Scripture
{
    private string reference;
    private string text;
    private List<Word> words;

    public bool AllWordsHidden { get { return words.TrueForAll(w => w.IsHidden); } }

    public Scripture(string reference, string text)
    {
        this.reference = reference;
        this.text = text;
        InitializeWords();
    }

    private void InitializeWords()
    {
        words = new List<Word>();

        string[] splitText = text.Split(' ');

        foreach (string wordText in splitText)
        {
            Word word = new Word(wordText);
            words.Add(word);
        }
    }

    public void HideRandomWord()
    {
        Random random = new Random();
        List<Word> visibleWords = words.FindAll(w => !w.IsHidden);

        if (visibleWords.Count > 0)
        {
            int randomIndex = random.Next(visibleWords.Count);
            visibleWords[randomIndex].Hide();
        }
    }

    public string GetFormattedScripture()
    {
        string formattedScripture = reference + "\n\n";

        foreach (Word word in words)
        {
            if (word.IsHidden)
                formattedScripture += "____ ";
            else
                formattedScripture += word.Text + " ";
        }

        return formattedScripture;
    }
}}