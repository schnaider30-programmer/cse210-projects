using System;

public class Swimming : Activity
{
    private int _lapNumber;

    public Swimming(DateTime date, int minutes, int lapNumber) : base(date, minutes)
    {
        _lapNumber = lapNumber;
    }

    public override double Distance()
    {
        return (_lapNumber * 50) / (double)1000;
    }

    public override double Speed()
    {
        return (Distance() / GetMinutes()) * 60;
    }

    public override double Pace()
    {
        return GetMinutes() / Distance();
    }

    public override string GetActivityType()
    {
        return "Swimming";
    }
    public override void GetSummary()
    {
        base.GetSummary();
    }
}
