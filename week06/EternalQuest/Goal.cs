using System;

public abstract class Goal
{
    string _shortName;
    string _description;
    int _points;

    public Goal(string name, string description, int points)
    {
        _shortName = name;
        _description = description;
        _points = points;
    }

    public string GetShortName()
    {
        return _shortName;
    }

    public string GetDescription()
    {
        return _description;
    }
    
    public int GetPoints()
    {
        return _points;
    }
    public abstract int RecordEvent();


    public abstract bool IsComplete();

    public virtual string GetDetailsString()
    {
        string message;
        
        message = $"[ ] {_shortName} ({_description})";
        return message;
    }

    public abstract string GetStringRepresentation();
    
}