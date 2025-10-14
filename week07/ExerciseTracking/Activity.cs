using System;

public abstract class Activity
{
    DateTime _date;
    int _minutes;

    public Activity(DateTime date, int minutes)
    {
        _date = date;
        _minutes = minutes;
    }

    public DateTime GetDateTime()
    {
        return _date;
    }

    public int GetMinutes()
    {
        return _minutes;
    }
    
    public virtual string GetActivityType()
    {
        return "Activty";
    }
    public abstract double Distance();
    public abstract double Speed();
    public abstract double Pace();

    public virtual void GetSummary()
    {
        Console.WriteLine($"{_date.ToString("dd MMM yyyy")} {GetActivityType()} ({_minutes} min)- Distance {Distance()} Km, Speed: {Speed():F2} Kph, Pace: {Pace():F2} min per Km\n");
    }

}