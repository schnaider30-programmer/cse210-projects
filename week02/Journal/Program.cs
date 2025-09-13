using System;

// I improved saving and loading files for csv files by adding proper CSV parsing to handle commas inside quoted fields.
//I also added a private method to help by adding quotes around each values. 
//The program will separate the contents of the files depending if it is a CSV file or not.


class Program
{
    static void Main(string[] args)
    {
        Journal journal = new Journal();
        int userChoice = -1;

        Console.WriteLine("Welcome to the Journal Program!");

        while (userChoice != 5)
        {

            Console.WriteLine("Please select one of the following choices: ");
            Console.WriteLine("1. Write");
            Console.WriteLine("2. Display");
            Console.WriteLine("3. Load");
            Console.WriteLine("4. Save");
            Console.WriteLine("5. Quit");

            Console.Write("What would you like to do? ");

            userChoice = int.Parse(Console.ReadLine());

            if (userChoice == 1)
            {
                PromptGenerator newPrompt = new PromptGenerator();

                string prompt = newPrompt.GetRandomPrompt();

                Console.WriteLine($"=> {prompt}");

                Console.Write("> ");
                string answer = Console.ReadLine();

                Entry nwEntry = new Entry(prompt, answer);

                journal.AddEntry(nwEntry);
            }

            else if (userChoice == 2)
            {
                journal.DisplayAll();
            }

            else if (userChoice == 3)
            {
                Console.WriteLine("What is the file name?");

                Console.Write("=> ");
                string filename = Console.ReadLine();

                journal.LoadFromFile(filename);
            }

            else if (userChoice == 4)
            {
                Console.WriteLine("What is the file name?");

                Console.Write("=> ");
                string filename = Console.ReadLine();

                journal.SaveToFile(filename);
            }
        }
    }
} 