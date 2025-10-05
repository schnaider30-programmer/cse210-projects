using System;
using System.Net;

public class ReflectingActivity : Activity
{
    private List<string> _prompts = new List<string>();

    private List<string> _questions = new List<string>();

    private List<string> _unusedPrompts;

    private List<string> _unusedQuestions;

    List<string> reflectionActivityQuestions = new List<string>
        {
            "Why was this experience meaningful to you?",
            "Have you ever done anything like this before?",
            "How did you get started?",
            "How did you feel when it was complete?",
            "What made this time different than other times when you were not as successful?",
            "What is your favorite thing about this experience?",
            "What could you learn from this experience that applies to other situations?",
            "What did you learn about yourself through this experience?",
            "How can you keep this experience in mind in the future?"
        };

    List<string> reflectionActivityPrompts = new List<string>
        {
            "Think of a time when you stood up for someone else.",
            "Think of a time when you did something really difficult.",
            "Think of a time when you helped someone in need.",
            "Think of a time when you did something truly selfless."
        };



    public ReflectingActivity()
    {
        _name = "Reflecting Activity";
        _description = "This activity will help you reflect on times in your life when you have shown strength and resilience.This will help you recognize the power you have and how you can use it in other aspects of your life.";
        _duration = 10;
        _prompts = reflectionActivityPrompts;
        _questions = reflectionActivityQuestions;
        _unusedPrompts = new List<string>(reflectionActivityPrompts);
        _unusedQuestions = new List<string>(reflectionActivityQuestions);

    }

    public ReflectingActivity(string name, string description, int duration) : base(name, description, duration)
    {

    }
    public ReflectingActivity(string name, string description, int duration, List<string> prompt, List<string> question) : base(name, description, duration)
    {
        _prompts = prompt;
        _questions = question;
    }

    public ReflectingActivity(List<string> prompt, List<string> question)
    {
        _name = "Reflecting Activity";
        _description = "This activity will help you reflect on times in your life when you have shown strength and resilience.This will help you recognize the power you have and how you can use it in other aspects of your life.";
        _duration = 0;
        _prompts = prompt;
        _questions = question;
    }

    public void Run()
    {
        DisplayStartingMessage();
        Console.Clear();

        DateTime start = DateTime.Now;
        DateTime end = start.AddSeconds(_duration);

        Console.WriteLine("Get Ready...");
        ShowSpinner(6);

        Console.WriteLine("\nConsider the following prompt: \n");
        DisplayPrompt();

        Console.WriteLine("When you have something in mind, press enter to continue.");
        string enter = Console.ReadLine();

        if (enter == "")
        {
            Console.WriteLine("Now ponder on each of the following questions as they related to this experience.");

            Console.Write($"You may begin in: ");
            ShowCountDown(4);
            Console.Clear();

            while (DateTime.Now < end)
            {
                GetRandomQuestion();
                DisplayQuestions();
                ShowSpinner(6);
            }
        }
        
        DisplayEndingMessage();

    }

    public string GetRandomPrompt()
    {
        return GetRandomUnique(_prompts, ref _unusedPrompts);
    }

    public string GetRandomQuestion()
    {
        return GetRandomUnique(_questions, ref _unusedQuestions);
    }

    public void DisplayPrompt()
    {
        Console.WriteLine($" -- {GetRandomPrompt()} --");
    }

    public void DisplayQuestions()
    {
        Console.WriteLine(GetRandomQuestion());
    }
}