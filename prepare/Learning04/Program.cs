using System;

class Program
{
    static void Main(string[] args)
    {
        Assignment assignment = new Assignment("Samuel Bennett", "Multiplication");
        string summary = assignment.GetSummary();

        Console.WriteLine(summary);

        WritingAssignment writingAssignemnt = new WritingAssignment("The Causes of World War II", "Mary Waters", "European History");
        Console.WriteLine(writingAssignemnt.GetSummary());
        Console.WriteLine(writingAssignemnt.GetWritingInformation());
    }
}