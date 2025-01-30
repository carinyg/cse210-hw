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
        Random random = new Random();
        var wordsToHide = _words.OrderBy(a => random.Next()).ToList();
        int count = 0;

        foreach (Word w in wordsToHide)
        {
            if (IsCompletelyHidden() == true)
                {
                    break;
                }

            else if (count == numberToHide)
            {
                break;
            }
            else if (w.IsHidden() == true)
            {
                continue;
            }
            else
            {
                w.Hide();
                count++;
                
            }       
        }

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
        foreach (Word w in _words)
        {
            if (!w.IsHidden())
            {
                return false;
            }
        }
        return true;
    }
}