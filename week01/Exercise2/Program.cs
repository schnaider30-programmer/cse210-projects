using System;
using System.Data;

class Program
{
    static void Main(string[] args)
    {

        string grade = "";
        string sign = "";

        Console.Write("What is your grade percentage? ");
        string answer = Console.ReadLine();
        int percentage = int.Parse(answer);

        if (percentage >= 90)
        {
            grade = "A";
        }
        else if (percentage >= 80)
        {
            grade = "B";
        }
        else if (percentage >= 70)
        {
            grade = "C";
        }
        else if (percentage >= 60)
        {
            grade = "D";
        }
        else
        {
            grade = "F";
        }

        int lastDigit = percentage % 10;

        if (lastDigit >= 7)
        {
            sign = "+";
        }
        else if (lastDigit <= 3)
        {
            sign = "-";
        }
        else
        {
            sign = "";
        }

        Console.WriteLine($"Your grade is {grade}{sign}");

        if (percentage >= 70)
        {
            Console.WriteLine("Congratulation! You passed!!!! :)");
            Console.WriteLine("You did great.");
        }
        else
        {
            Console.WriteLine("You failed!!!!");
            Console.WriteLine("It is ok. You will do better next time!!!!");
        }
    }
}