using System;
using System.IO;

class Program
{
    static void Main(string[] args)
    {
        string[] lines = File.ReadAllLines("Scriptures.txt").Skip(1).ToArray();

        if (lines.Length == 0)
        {
            Console.WriteLine("No scripture found.");
            return;
        }

        Random rnd = new Random();
        int linePosition = rnd.Next(lines.Length);
        string randomLine = lines[linePosition];

        string[] parts = randomLine.Split('|');
        string referencePart = parts[0].Trim().Trim('"');
        string[] newReference = referencePart.Split(' ');
        string book = newReference[0];
        int chapter = int.Parse(newReference[1]);
        int verseStart = int.Parse(newReference[2]);
        int verseEnd = verseStart;

        References reference;
        if (newReference.Length > 3 && !string.IsNullOrWhiteSpace(newReference[3]))
        {
            verseEnd = int.Parse(newReference[3]);
            reference = new References(book, chapter, verseStart, verseEnd);
        }
        else
        {
            reference = new References(book, chapter, verseStart);
        }

        string text = parts[1].Trim().Trim('"');
        Scriptures newScriptures = new Scriptures(reference, text);

            string displayText = newScriptures.GetDisplayText();
            Console.Clear();
            Console.WriteLine(displayText);

        while (!newScriptures.IsCompletyHidden())
        {
            Console.WriteLine("\nPress enter to continue or type 'quit' to finish:");
            string entryUser = Console.ReadLine();

            if (entryUser == "")
            {
                Console.Clear();
                newScriptures.HideRandomWords(3);

                string newDisplay = newScriptures.GetDisplayText();
                Console.WriteLine(newDisplay);
            }
            else
            {
                break;
            }

        }

    }
}