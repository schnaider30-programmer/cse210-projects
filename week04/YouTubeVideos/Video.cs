using System;

public class Video
{
    public string _title;
    public string _author;
    public double _lengthInSecond;
    List<Comment> _comments = new List<Comment>();

    public void ListOfComment(Comment newComment)
    {
        _comments.Add(newComment);
    }
    public int GetNumberOfComments()
    {
        return _comments.Count;
    }

    public string GetAllCommentsText()
    {
        string allComments = "";
        int i = 1;

        foreach (Comment comment in _comments)
        {
            string eachComment = comment._text;
            allComments += $"{i}-{eachComment}\n";
            i++;
        }
        
        return allComments;
    }
 }