public class BreathingActivity : Activity
{
    public BreathingActivity()
    {
        _name = "Breathing Activity";
        _description = "This activity will help you relax by walking your through breathing in and out slowly.Clear your mind and focus on your breathing.";
        _duration = 0;
    }
    public BreathingActivity(string name, string description, int duration) : base(name, description, duration)
    {

    }
    public void Run()
    {

        DisplayStartingMessage();

        DateTime start = DateTime.Now;
        DateTime end = start.AddSeconds(_duration);

        Console.Clear();

        Console.WriteLine("Get Ready...");
        ShowSpinner(6);

        while (DateTime.Now < end)
        {
            Console.Write("\nBreathe in...");
            ShowCountDown(4);
            Console.Write("\nBreathe Out...");
            ShowCountDown(6);
            Console.WriteLine();
        }
        

        DisplayEndingMessage();
    }
        
     
}