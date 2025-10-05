using System;

class Program
{
    static void Main(string[] args)
    {
        Assignment ass1 = new Assignment("Samuel Bennet", "Multiplication");

        string firstAssignment = ass1.GetSummary();

        Console.WriteLine(firstAssignment);
        Console.WriteLine();

        MathAssignment ass2 = new MathAssignment("Roberto Rodriguez", "Fractions", "7.3", "8-19");
        string summary = ass2.GetSummary();
        string sectionProblem = ass2.GetHommeworkList();

        Console.WriteLine(summary);
        Console.WriteLine(sectionProblem);

        Console.WriteLine();
        WritingAssignment ass3 = new WritingAssignment("Mary Waters", "European History", "The causes of the World War II");

        string newSummary = ass3.GetSummary();
        string summaryInfo = ass3.GetWritingInformation();

        Console.WriteLine(newSummary);
        Console.WriteLine(summaryInfo);
    }
}