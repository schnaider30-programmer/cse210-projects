using System;
using System.Globalization;

class Program
{
    static void Main(string[] args)
    {
        Random randomGenerator = new Random();
        int magicNumber = randomGenerator.Next(1, 100);
        int numberOfGuessing = 0;
        int guess = -1;
        while (guess != magicNumber)
        {
            numberOfGuessing += 1;
            Console.Write("What is your guess? ");
            int userInteger = int.Parse(Console.ReadLine());

            if (userInteger < magicNumber)
            {
                Console.WriteLine("Higher");
            }
            else if (userInteger > magicNumber)
            {
                Console.WriteLine("Lower");
            }

            else
            {
                Console.WriteLine("You guessed it!");
                Console.WriteLine($"It took you {numberOfGuessing} guess(es)");

                //The user can choose to play again 

                Console.Write("\nDo you want play again? (Type 'y' for yes or 'n' for no) ");
                string playAgain = Console.ReadLine();

                if (playAgain == "y")
                {
                    numberOfGuessing = 0;
                    magicNumber = randomGenerator.Next(1, 100);
                    continue;
                }
                else
                {
                    Console.WriteLine("Hope to see you soon!!!");
                    break;
                }

            }
        }



    }
}