using System;
using System.Globalization;


public class Scriptures
{
    References _reference;
    List<Word> _words = new List<Word>();

    public Scriptures(References references, string text)
    {
        _reference = references;
        foreach (string w in text.Split(' '))
        {
            Word newWord = new Word(w);
            _words.Add(newWord);
        }
    }

    public void HideRandomWords(int numberToHide)
    {
        Random randomIndex = new Random();
        int hiddenCount = 0;

        // Any() is LINQ method to check if at leat one element is true.
        //w => !w.IsHidden() is a lambda function that say to continue as long as there is the Word w visible. !w.IsHidden().

        while (hiddenCount < numberToHide && _words.Any(w => !w.IsHidden()))
        {
            int index = randomIndex.Next(_words.Count);
            if (!_words[index].IsHidden())
            {
                _words[index].Hide();
                hiddenCount++;
            }
        }
    }

    public string GetDisplayText()
    {
        string textDisplay = string.Join(" ", _words);

        return $"{_reference.GetDisplayText()} {textDisplay}";
    }
    public bool IsCompletyHidden()
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