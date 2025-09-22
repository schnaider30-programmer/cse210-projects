using System;

public class Word
{
    private string _text;
    private bool _isHidden;
    public Word(string text)
    {
        _text = text;
        _isHidden = false;
    }

    //To tell the class what to return when calling the class Word as a string if not by default will return the name of the class when called as a string.
    public override string ToString()
    {
        return GetDisplayText();
    }
    public void Hide()
    {
        //To change the state of the hidden word to Hide it
        _isHidden = true;
    }
    //To change the state of the hidden word to Show it
    public void Show()
    {
        _isHidden = false;
    }

    //A getter method to know the value of the attribute _isHidden
    public bool IsHidden()
    {
        return _isHidden;
    }

    public string GetDisplayText()
    {
        if (_isHidden)
        {
            //new string('_', _text.Length) to a character a number of time defined
            
            string _textDisplay = new string('_', _text.Length);
            return _textDisplay;
        }
        else
        {
            return _text;
        }

    }
}