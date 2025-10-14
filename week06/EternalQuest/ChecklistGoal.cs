using System;
public class ChecklistGoal : Goal
{
    private int _amountCompleted = 0;
    private int _targets = 0;
    private int _bonus = 0;

    private bool _bonusGiven = false;

    public ChecklistGoal(string name, string description, int points) : base(name, description, points)
    {
        
    }
    public ChecklistGoal(string name, string description, int points, int bonus, int targets) : base(name, description, points)
    {

        _targets = targets;
        _bonus = bonus;
    }

    public void SetTargets(int targets)
    {
        _targets = targets;
    }

    public int GetTarget()
    {
        return _targets;
    }

    public int GetAmountCompleted()
    {
        return _amountCompleted;
    }

    public void SetAmountCompleted(int amountCompleted)
    {
        _amountCompleted = amountCompleted;
    }


   
    public override int RecordEvent()
    {
        _amountCompleted++;

        if (_amountCompleted < _targets)
        {
            Console.WriteLine($"Congratulations! You have earned {GetPoints()} points");

            return GetPoints();
        }
        else if (_amountCompleted == _targets && !_bonusGiven)
        {
            _bonusGiven = true;
            Console.WriteLine($"Congratulations! You have earned {GetPoints() + _bonus}");

            return GetPoints() + _bonus;
        }
        else
        {
            Console.WriteLine("You have already complete this goal.");
            return 0;

        }
    }


    //Même comportement, mais la structure est plus claire : on bloque d’abord les appels inutiles, puis on traite le cas bonus, puis le cas normal.

    // public override int RecordEvent()
    // {
    //     if (_amountCompleted >= _targets)
    //     {
    //         Console.WriteLine("You have already completed this goal.");
    //         return 0;
    //     }

    //     _amountCompleted++;

    //     if (_amountCompleted == _targets && !_bonusGiven)
    //     {
    //         _bonusGiven = true;
    //         Console.WriteLine($"Congratulations! You have earned {GetPoints()} points + bonus of {_bonus}!");
    //         return GetPoints() + _bonus;
    //     }
    //     else
    //     {
    //         Console.WriteLine($"Congratulations! You have earned {GetPoints()} points");
    //         return GetPoints();
    //     }
    // }

    public override string GetDetailsString()
    {
        string chechbox = IsComplete() ? "[X]" : "[ ]";
        return $"{chechbox} {GetShortName()} ({GetDescription()} -- Currently Completed {_amountCompleted}/{_targets})";
    }

    public override bool IsComplete()
    {
        if (_amountCompleted < _targets)
        {
            return false;
        }
        else
        {
            return true;
        }
    }

    public override string GetStringRepresentation()
    {
        return $"ChecklistGoal|{GetShortName()}|{GetDescription()}|{GetPoints()}|{_bonus}|{_targets}|{_amountCompleted}";
    }

}