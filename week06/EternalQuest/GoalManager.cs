using System;
using System.Net;
using Microsoft.Win32.SafeHandles;
using System.IO;

public class GoalManager
{
    List<Goal> _goals = new List<Goal>();

    int _score = 0;

    int prevLevel;

    public void Start()
    {
        Console.WriteLine($"{new string('*', 50)}");
        Console.WriteLine("Growth is an everlasting journey!");
        Console.WriteLine("Your journey start now!");
        Console.WriteLine($"{new string('*', 50)}\n");

        int choice;
        do
        {

            DisplayPlayerInfo();
            Console.WriteLine("Menu Options: ");

            Console.WriteLine("  1.Create New Goals");
            Console.WriteLine("  2.List Goals");
            Console.WriteLine("  3.Save Goals");
            Console.WriteLine("  4.Load Goals");
            Console.WriteLine("  5.Record Event");
            Console.WriteLine("  6.Quit");

            Console.Write("Please choose your new quest: ");
            choice = int.Parse(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    CreateGoal();
                    break;
                case 2:
                    ListGoalDetails();
                    break;
                case 3:
                    SaveGoals();
                    break;
                case 4:
                    LoadGoals();
                    break;
                case 5:

                    RecordEvent();
                    break;
                case 6:
                    break;
                default:
                    Console.WriteLine("Invalid option. Please choose a valid option.");
                    break;
            }

        } while (choice != 6);

    }

    public void DisplayPlayerInfo()
    {
        Console.WriteLine($"You have {_score} points.");
        Console.WriteLine($"You are level {GetLevel()}\n");


    }

    public void ListGoalNames()
    {
        int i = 0;
        Console.WriteLine("The goals are: ");

        foreach (Goal g in _goals)
        {
            Console.WriteLine($"{i + 1}. {g.GetShortName()}");
            i++;
        }
    }

    public void ListGoalDetails()
    {
        if (_goals.Count() < 1)
        {
            Console.WriteLine("You do not have any goal listed here yet.");
        }
        else
        {
            int i = 1;
            foreach (Goal g in _goals)
            {
                Console.WriteLine($"{i}. {g.GetDetailsString()}");
                i++;
            }
        }

    }

    public void CreateGoal()
    {
        Console.WriteLine("The type of Goals are: ");
        Console.WriteLine("  1. Simple Goal");
        Console.WriteLine("  2. Eternal Goal");
        Console.WriteLine("  3. Checklist Goal");
        Console.Write("Which type of goal would you like to create? ");

        int goalChoice = int.Parse(Console.ReadLine());

        Console.Write("What is the name of the goal? ");
        string name = Console.ReadLine().ToString();

        Console.Write("What is a short description of it? ");
        string description = Console.ReadLine().ToString();

        Console.Write("What is the amount of points associated with this goal? ");
        int points = int.Parse(Console.ReadLine());

        Goal newGoal = null;

        switch (goalChoice)
        {
            case 1:
                newGoal = new SimpleGoal(name, description, points);
                break;

            case 2:
                newGoal = new EternalGoal(name, description, points);
                break;

            case 3:
                Console.Write("How many times does this goal need to be accomplished for a bonus ");

                int target = int.Parse(Console.ReadLine());

                Console.Write($"What is the bonus for accomplishing it {target} time(s)? ");

                int bonus = int.Parse(Console.ReadLine());

                newGoal = new ChecklistGoal(name, description, points, bonus, target);
                break;
        }

        _goals.Add(newGoal);

    }
    public void RecordEvent()
    {
        ListGoalNames();
        Console.Write("Which goal did you accomplish? ");
        int index = int.Parse(Console.ReadLine());
        int goalIndex = index - 1;

        if (goalIndex >= 0 && goalIndex <= _goals.Count())
        {
            prevLevel = GetLevel();
            _score += _goals[goalIndex].RecordEvent();
            int newLevel = GetLevel();
            if (newLevel > prevLevel)
            {
                Console.WriteLine($"🎉 Level Up! You are now Level {newLevel}!");

            }
        }
    
        else
        {
            Console.WriteLine("Please type a valid number.");
        }
    }

    public void SaveGoals()
    {
        Console.Write("What is the name of the goals file? ");
        string filename = Console.ReadLine();

        using (StreamWriter outputFile = new StreamWriter(filename))
        {
            outputFile.WriteLine($"{_score}");
            outputFile.WriteLine($"{GetLevel()}");
            foreach (Goal g in _goals)
            {
                outputFile.WriteLine(g.GetStringRepresentation());
            }
        }

    }

    public void LoadGoals()


    {
        Console.Write("What is the filename for the foal file? ");

        string filename = Console.ReadLine();

        string[] lines = System.IO.File.ReadAllLines(filename);

        
        _score = int.Parse(lines[0]);
        prevLevel = int.Parse(lines[1]);

        for (int i = 2; i < lines.Length; i++)
        {
            string line = lines[i].Trim();

            string[] part = line.Split("|");
            string type = part[0].ToLower();

            if (type == "simplegoal")
            {
                SimpleGoal simpGoal = new SimpleGoal(part[1].Trim(), part[2].Trim(), int.Parse(part[3].Trim()));
                bool complete = bool.Parse(part[4].Trim());
                simpGoal.SetCompletionState(complete);

                _goals.Add(simpGoal);
            }
            else if (type == "eternalgoal")
            {
                EternalGoal loadGoal = new EternalGoal(part[1].Trim(), part[2].Trim(), int.Parse(part[3].Trim()));
                _goals.Add(loadGoal);
            }
            else if (type == "checklistgoal")
            {
                ChecklistGoal checkGoal = new ChecklistGoal(part[1].Trim(), part[2].Trim(), int.Parse(part[3].Trim()), int.Parse(part[4].Trim()), int.Parse(part[5].Trim()));
                checkGoal.SetAmountCompleted(int.Parse(part[6]));

                _goals.Add(checkGoal);
            }
        }

    }

    public int GetLevel()
    {
        int level = 1;
        int threshold = 500; 

        while(_score >= threshold)
        {
            level++;
            threshold *= 2;
        }
        return level;
    }

}

