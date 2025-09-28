using System;

public class Comment
{
    public string _name;
    public string _text;

    public void AddCommentText(string text)
    {
        _text = text;
    }

    public void AddAuthorOfComment(string name)
    {
        _name = name;
    }
    public void DisplayText()
    {

    }
}