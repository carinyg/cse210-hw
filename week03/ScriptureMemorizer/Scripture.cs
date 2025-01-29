using System;
using System.Collections.Generic;

public class Scripture
{
    private Reference _reference;
    private List<Word> _words = new List<Word>();

    public Scripture(Reference Reference, string text)
    {
        _reference = Reference;
        
        string[] splitText = text.Split(' ');

        foreach (string word in splitText)
        {
            Word w = new Word(word);
            _words.Add(w);
        }

    }

    public void HideRandomWords(int numberToHide)
    {
        bool test;

        do{
            Random rand = new Random();
            int randomIndex = rand.Next(0, _words.Count);

            int repeat = numberToHide;

            do{
                if (_words[randomIndex].IsHidden() == false)
                {
                    _words[randomIndex].Hide();
                    repeat--;
                }
                else
                {
                    randomIndex = rand.Next(0, _words.Count);
                }

                test = IsCompletelyHidden();
            }while(repeat > 0);

        }while(test == true);

    }

    public string GetDisplayText()
    {
        string displayText = "";
        foreach (Word w in _words)
        {
            displayText += w.GetDisplayText() + " ";
        }
        return displayText;
    }

    public bool IsCompletelyHidden()
    {
        bool fullyHidden = true;

        foreach (Word w in _words)
        {
            if (w.IsHidden() == false)
            {
                fullyHidden = false;
            }
        }

        return fullyHidden;
    }
}