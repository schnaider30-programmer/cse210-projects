using System;

class Program
{
    static void Main(string[] args)
    {
        References reference = new References("Proverb", 3, 5, 6);

        Scriptures newScriptures = new Scriptures(reference, "Trust in the Lord with all your heart, and do not lean on your own understanding. In all your ways acknowledge him, and he will make straight your paths.");
        Console.WriteLine("");

        while (!newScriptures.IsCompletyHidden())
        {
            string displayText = newScriptures.GetDisplayText();
            Console.WriteLine(displayText);

            Console.WriteLine("\nPress enter to continue or type 'quit' to finish:");
            string entryUser = Console.ReadLine();

            if (entryUser == "")
            {
                Console.Clear();
                newScriptures.HideRandomWords(3);
            }
            else
            {
                break;
            }

        }

    }
}