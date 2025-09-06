using System;
using System.Formats.Asn1;

class Program
{
    static void Main(string[] args)
    {
        List<int> numberList = new List<int>();
        int newNumber = -1;
        int total = 0;
        int smallestPositive = 999999999;

        Console.WriteLine("Enter a list of numbers, type 0 when finished.");

        while (newNumber != 0)
        {
            Console.Write("Enter a number: ");
            newNumber = int.Parse(Console.ReadLine());
            if (newNumber == 0)
            {
                break;
            }
            else
            {
                numberList.Add(newNumber);
            }
        }

        int largest = numberList[0];

        foreach (int number in numberList)
        {
            total += number;
            if (largest < number)
            {
                largest = number;
            }
            else if (smallestPositive > number && smallestPositive > 0)
            {
                smallestPositive = number;
            }
        }
 
        float average = total / ((float)numberList.Count);

        Console.WriteLine($"The total is {total}");
        Console.WriteLine($"The average is {average}");
        Console.WriteLine($"The largest number is {largest}");
        Console.WriteLine($"The smallest positive number is {smallestPositive}");
    }
}