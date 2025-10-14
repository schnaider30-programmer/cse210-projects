using System;

public class Running : Activity

{
    double _distance;

    public Running(DateTime date, int minutes, double distance) : base(date, minutes)
    {
        _distance = distance;
    }
    public override double Distance()
    {
        return _distance;
    }

    public override double Speed()
    {
        return (_distance / GetMinutes()) * 60;
    }

    public override double Pace()
    {
        return GetMinutes() / _distance;
    }

    public override string GetActivityType()
    {
        return "Running";
    }
    public override void GetSummary()
    {
        base.GetSummary();
    }
}