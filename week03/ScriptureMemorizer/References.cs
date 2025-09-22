using System;

public class References
{
    private int _chapter;
    private int _verse;
    private int _endVerse;
    private string _book;

    public References(string book, int chapter, int verse)
    {
        _book = book;
        _chapter = chapter;
        _verse = verse;
        _endVerse = -1;
    }
    public References(string book, int chapter, int verse, int endVerse )
    {
        _book = book;
        _chapter = chapter;
        _verse = verse;
        _endVerse = endVerse;
    }
    public string GetDisplayText()
    {
        if (_endVerse == -1)
        {
            return $"{_book} {_chapter}:{_verse}";
        }
        else
        {
            return $"{_book} {_chapter}: {_verse}-{_endVerse}";
        }
    }
}