using System;

public class SimpleGoal : Goal
{
    bool _isComplete;


    //This is a best practice in object-oriented design: always make the object's state clear and predictable from the start.

    //Even though false is the default for a bool, I explicitly setted it to makes my intent obvious to anyone reading the code (including future me).

    public SimpleGoal(string name, string description, int points) : base(name, description, points)
    {
        _isComplete = false;
    }
    public override int RecordEvent()
    {
        _isComplete = true;
        Console.WriteLine($"Congratulations! You have earned {GetPoints()} points");
        return GetPoints();
    }

    public override string GetDetailsString()
    {
        string chechbox = IsComplete() ? "[X]" : "[ ]";

        return $"{chechbox} {GetShortName()} ({GetDescription()})";
    }

    public override bool IsComplete()
    {
        if (_isComplete)
        {
            return true;
        }
        return false;
    }

    public void SetCompletionState(bool isComplete)
    {
        _isComplete = isComplete;
    }

    public bool GetCompletionState()
    {
        return _isComplete;
    }

    public override string GetStringRepresentation()
    {
        return $"SimpleGoal|{GetShortName()}|{GetDescription()}|{GetPoints()}|{IsComplete()}";
    }
}