using System;

class Program
{
    static void Main(string[] args)
    {
        DateTime date = DateTime.Today;

        Running run1 = new Running(date, 45, 2.3);

        Swimming swim = new Swimming(date, 30, 10);

        StationaryBicycle bic1 = new StationaryBicycle(date, 60, 20);

        List<Activity> activities = new List<Activity>
        {
            run1, swim, bic1
        };

        for(int i = 0; i < activities.Count(); i++)
        {
            activities[i].GetSummary();
        }

    }
}
/*
// Although this object is instantiated as a Running activity,
// it is referenced through the base class type (Activity).
// This allows us to store different activity types in a single list
// and use polymorphism to call overridden methods like GetSummary().
// However, only methods defined in the base class are accessible
// through this reference unless we cast it back to the derived type.
Activity run1 = new Running(date, minutes, distance);*/
