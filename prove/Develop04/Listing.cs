using System;
using System.Collections.Generic;
using System.Threading;

public class ListingActivity : BaseActivity
{
    private List<FlaggedString> _prompts;

    public ListingActivity()
        : base("Listing Activity", 
               "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.")
    {
        SetPrompts();
    }

    public void RunListingActivity()
    {
        DisplayGreeting();
        DisplayDescription();
        ObtainDuration();
        StartTime();

        Console.Clear();
        Console.WriteLine("Get ready...");
        DisplaySpinner("Preparing", 3);
        Console.Clear();

        // Get and display a random prompt
        string prompt = GetPromptString(_prompts);
        Console.WriteLine("List as many responses as you can to the following prompt:");
        Console.WriteLine($"--- {prompt} ---");
        Console.Write("You may begin in: ");
        RunCountDown("", 5);
        Console.WriteLine();

        int itemCount = 0;
        List<string> responses = new List<string>();

        while (!HasTimeExpired())
        {
            Console.Write("> ");
            string input = Console.ReadLine();
            
            if (!string.IsNullOrWhiteSpace(input))
            {
                responses.Add(input);
                itemCount++;
            }
        }


        Console.WriteLine($"\nYou listed {itemCount} items!");
        DisplayEnding();
    }

    private void SetPrompts()
    {
        _prompts = new List<FlaggedString>()
        {
            new FlaggedString("Who are people that you appreciate?", false),
            new FlaggedString("What are personal strengths of yours?", false),
            new FlaggedString("Who are people that you have helped this week?", false),
            new FlaggedString("When have you felt the Holy Ghost this month?", false),
            new FlaggedString("Who are some of your personal heroes?", false)
        };
    }
}
