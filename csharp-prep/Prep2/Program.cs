using System;
using System.Globalization;

class Program
{
    static void Main(string[] args)
    {
        // Get user input and change to int
        Console.Write("What is your grade percentage? ");
        string userInput = Console.ReadLine();
        int x = int.Parse(userInput);

        // Letter grade variable
        string letter = "";

        // Determine letter grade
        if (x >= 90)
        {
            letter = "A";
        }
        else if (x >= 80)
        {
            letter = "B";
        }
        else if (x >= 70)
        {
            letter = "C";
        }
        else if (x >= 60)
        {
            letter = "D";
        }
        else
        {
            letter = "F";
        }

        // Print letter grade
        Console.WriteLine($"Your letter grade is {letter}");

        // Pass or Fail statement
        if (x >= 70)
        {
            Console.WriteLine("You passed! Congratulations!!!");
        }
    }
}