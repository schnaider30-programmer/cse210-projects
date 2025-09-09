using System;
using System.ComponentModel.DataAnnotations;

public class Job
{
    // The method of using a constructor or a special method to initialize objects.
    
    // public string _company;
    // public string _jobTitle;
    // public int _startYear;
    // public int _endYear;
    // public Job(string company, string jobTitle, int startYear, int endYear)
    // {
    //     _company = company;
    //     _jobTitle = jobTitle;
    //     _startYear = startYear;
    //     _endYear = endYear;
    // }


    public string _company;
    public string _jobTitle;
    public int _startYear;
    public int _endYear;
    public void Display()
    {
        Console.WriteLine($"{_jobTitle} ({_company}) {_startYear}-{_endYear}");
    }
}