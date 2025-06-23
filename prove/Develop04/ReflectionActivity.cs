using System;
using System.Collections.Generic;
using System.Threading;

public class ReflectionActivity : BaseActivity
{
    private List<FlaggedString> _prompts;
    private List<FlaggedString> _questions;

    public ReflectionActivity()
        : base("Reflection Activity", 
               "This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.")
    {
        SetPrompts();
        SetQuestions();
    }

    public void RunReflectionActivity()
    {
        DisplayGreeting();
        DisplayDescription();
        ObtainDuration();
        StartTime();

        Console.Clear();
        Console.WriteLine("Get ready...");
        DisplaySpinner("Preparing", 3);
        Console.Clear();

        // Show a random prompt
        string prompt = GetPromptString(_prompts);
        Console.WriteLine("Consider the following prompt:");
        Console.WriteLine($"--- {prompt} ---\n");
        Console.WriteLine("When you have something in mind, press Enter to continue.");
        Console.ReadLine();
        Console.Clear();

        Console.WriteLine("Now ponder on each of the following questions as they relate to this experience:\n");

        // Loop through questions while time remains
        while (!HasTimeExpired())
        {
            string question = GetPromptString(_questions);
            Console.Write($"> {question} ");
            DisplaySpinner("", 5);
            Console.WriteLine();
        }

        Console.WriteLine("\nWell done!!");
        DisplayEnding();
    }

    private void SetPrompts()
    {
        _prompts = new List<FlaggedString>()
        {
            new FlaggedString("Think of a time when you stood up for someone else.", false),
            new FlaggedString("Think of a time when you did something really difficult.", false),
            new FlaggedString("Think of a time when you helped someone in need.", false),
            new FlaggedString("Think of a time when you did something truly selfless.", false)
        };
    }

    private void SetQuestions()
    {
        _questions = new List<FlaggedString>()
        {
            new FlaggedString("Why was this experience meaningful to you?", false),
            new FlaggedString("Have you ever done anything like this before?", false),
            new FlaggedString("How did you get started?", false),
            new FlaggedString("How did you feel when it was complete?", false),
            new FlaggedString("What made this time different than other times?", false),
            new FlaggedString("What is your favorite thing about this experience?", false),
            new FlaggedString("What did you learn about yourself through this experience?", false),
            new FlaggedString("How can you keep this experience in mind in the future?", false)
        };
    }
}
