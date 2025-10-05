//I made sure no random prompts or questions from the list of random prompts and the list of randoms questions are selected until they have all been used at least once in that session.

using System;
using System.Runtime.InteropServices;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine();

        bool running = true;
        
        while (running == true)
        {
            Console.Clear();
            Console.WriteLine($"{new string('=', 40)}");
            Console.WriteLine("Welcome to the Mindfullness Program.");
            Console.WriteLine($"{new string('=', 40)}\n");

            Console.WriteLine("Here you can find a list of activities to helps you reach a complete state of ~Mindfullness~ !\n");

            Console.WriteLine("Menu Options:");
            Console.WriteLine("  1. Start breathing activity");
            Console.WriteLine("  2. Start reflecting activity");
            Console.WriteLine("  3. Start listing activity");
            Console.WriteLine("  4. Quit");

            Console.Write("Please Choose an option: ");
            int optionSelected = int.Parse(Console.ReadLine());

            if (optionSelected == 1)
            {
                BreathingActivity breathActivity = new BreathingActivity();
                breathActivity.Run();
            }

            else if (optionSelected == 2)
            {
                ReflectingActivity reflect = new ReflectingActivity();
                reflect.Run();
            }

            else if (optionSelected == 3)
            {
                ListingActivity listActivity = new ListingActivity();
                listActivity.Run();
            }

            else if (optionSelected == 4)
            {
                break;
            }

            else
            {
                Console.WriteLine("Please choose from the range (1-4)");
                running = true;
            }
        }
    }
}