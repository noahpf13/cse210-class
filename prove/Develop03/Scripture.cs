using System;
using System.Collections.Generic;

public class Scripture
{
    private Reference _reference;
    private List<Word> _words = new List<Word>();

    // Constructor that takes a reference and the full scripture text
    public Scripture(Reference reference, string text)
    {
        _reference = reference;

        // Split the scripture into words and add each one as a Word object
        string[] wordArray = text.Split(' ');

        foreach (string wordText in wordArray)
        {
            Word word = new Word(wordText);
            _words.Add(word);
        }
    }

    // Returns the full scripture with hidden words replaced by underscores
    public string GetDisplayText()
    {
        string result = _reference.DisplayText() + " - ";

        foreach (Word word in _words)
        {
            result += word.GetDisplayText() + " ";
        }

        return result.Trim();
    }

    // Hides a few random words that haven't been hidden yet
    public void HideRandomWords(int numberToHide)
    {
        Random rand = new Random();
        int hidden = 0;

        while (hidden < numberToHide)
        {
            int index = rand.Next(_words.Count);
            Word word = _words[index];

            if (!word.IsHidden())
            {
                word.Hide();
                hidden++;
            }

            // Stop early if all words are already hidden
            if (AllWordsHidden())
            {
                break;
            }
        }
    }

    // Checks if all words are hidden
    public bool AllWordsHidden()
    {
        foreach (Word word in _words)
        {
            if (!word.IsHidden())
            {
                return false;
            }
        }

        return true;
    }
}
