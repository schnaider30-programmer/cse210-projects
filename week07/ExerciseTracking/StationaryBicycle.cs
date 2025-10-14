using System;

public class StationaryBicycle : Activity
{
    private int _speed;

    public StationaryBicycle(DateTime date, int minutes, int speed) : base(date, minutes)
    {
        _speed = speed;
    }

    public override double Speed()
    {
        return _speed;
    }

    public override double Distance()
    {
        return _speed * GetMinutes() / 60;
    }

    public override double Pace()
    {
        return GetMinutes() / Distance();
    }

    public override string GetActivityType()
    {
        return "Stationary Bicycle";
    }

    public override void GetSummary()
    {
        base.GetSummary();
    }
}