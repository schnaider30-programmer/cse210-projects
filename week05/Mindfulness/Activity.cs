using System.Xml.Serialization;

public class Activity
{
    protected string _name;
    protected string _description;
    protected int _duration;

    public Activity()
    {

    }

    public Activity(string name, string description, int duration)
    {
        _name = name;
        _description = description;
        _duration = duration;
    }

    public void SetName(string name)
    {
        _name = name;
    }
    public void DisplayStartingMessage()
    {

        Console.WriteLine($"Welcome to the {_name}\n");
        Console.WriteLine($"{_description}\n");

        Console.Write($"How long, in seconds, would you like for your session? ");
        _duration = int.Parse(Console.ReadLine());
    }

    public void DisplayEndingMessage()
    {
        Console.WriteLine("\nWell Done!!!\n");
        ShowSpinner(6);
        Console.WriteLine($"You have completed another {_duration} seconds of the {_name}");
        ShowSpinner(6);
    }
    public void ShowSpinner(int seconds)
    {
        List<string> spinChars = new List<string>();
        spinChars.Add("|");
        spinChars.Add("/");
        spinChars.Add("-");
        spinChars.Add("\\");

        int looping = 0;
        while (looping < seconds)
        {
            foreach (string spinChar in spinChars)
            {
                if (looping >= seconds)
                {
                    break;
                }
                Console.Write(spinChar);
                Thread.Sleep(1000);
                Console.Write("\b \b");
                looping++;
            }
        }

    }

    public void ShowCountDown(int second)
    {
        for (int i = second; i > 0; i--)
        {
            Console.Write(i);
            Thread.Sleep(1000);
            Console.Write("\b \b");
        }
    }

    public string GetRandomUnique(List<string> source, ref List<string> unused)
    {
        if (unused.Count == 0) //If the new temporary list "unused" is empty, then unused takes the value of the first list
        {
            unused = new List<string>(source);
        }
        Random rand = new Random();
        int index = rand.Next(unused.Count());
        string item = unused[index];
        unused.RemoveAt(index);

        return item;
    }
}