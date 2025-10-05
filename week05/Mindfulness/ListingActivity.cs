using System;

public class ListingActivity : Activity
{
    private int _count;
    
    private List<string> _prompts = new List<string>();
    private List<string> _unusedPrompts;

    List<string> listingActivityPrompts = new List<string>
        {
            "Who are people that you appreciate?",
            "What are personal strengths of yours?",
            "Who are people that you have helped this week?",
            "When have you felt the Holy Ghost this month?",
            "Who are some of your personal heroes?"
        };

    public ListingActivity()
    {
        _name = "Listing Activity";
        _description = "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.";
        _duration = 0;
        _prompts = listingActivityPrompts;
        _unusedPrompts = _prompts;
    }

    public ListingActivity(string name, string description, int duration) : base(name, description, duration)
    {
    
    }

    public ListingActivity(string name, string description, int duration, List<string> prompts) : base(name, description, duration)
    {
        _prompts = prompts;
    }

    public ListingActivity(List<string> prompts)
    {
        _prompts = prompts;
    }
    public void Run()
    {
        DisplayStartingMessage();
        Console.Clear();

        DateTime start = DateTime.Now;
        DateTime end = start.AddSeconds(_duration);

        Console.WriteLine("Get Ready...");
        ShowSpinner(6);

        Console.WriteLine("List as many responses you to the following prompt: ");
        DisplayPrompt();

        Console.Write("You may begin in: ");
        ShowCountDown(6);
        Console.WriteLine();

        while (DateTime.Now < end)
        {
            Console.Write(">");
            string userList = Console.ReadLine();
            _count++;
        }

        Console.WriteLine($"You listed {_count} item(s)!");

        DisplayEndingMessage();

    }
    public string GetRandomPrompt()
    {
        return GetRandomUnique(_prompts, ref _unusedPrompts);

    }

    public void DisplayPrompt()
    {
        Console.WriteLine($" -- {GetRandomPrompt()} --");
    }
    public List<string> GetListFromUser(string input)
    {
        List<string> userInputList = new List<string>();
        userInputList.Add(input);

        return userInputList;
    }
    
    
}