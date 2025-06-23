using System;
using System.Collections.Generic;
using System.Threading;

public class BaseActivity
{
    private string _name;
    private string _description;
    private int _duration;
    private DateTime _endTime;

    // Constructor
    public BaseActivity(string name, string description)
    {
        _name = name;
        _description = description;
    }

    // Display methods
    public void DisplayGreeting()
    {
        Console.Clear();
        Console.WriteLine($"Welcome to the {_name}!");
        Console.WriteLine();
    }

    public void DisplayDescription()
    {
        Console.WriteLine(_description);
        Console.WriteLine();
    }

    public void DisplayEnding()
    {
        Console.WriteLine($"\nYou have completed {_duration} seconds of the {_name}.");
    }

    // Prompt for session duration
    public void ObtainDuration()
    {
        Console.Write("How long, in seconds, would you like for your session? ");
        _duration = int.Parse(Console.ReadLine());
        Console.WriteLine();
    }

    // Time tracking
    public void StartTime()
    {
        _endTime = DateTime.Now.AddSeconds(_duration);
    }

    public bool HasTimeExpired()
    {
        return DateTime.Now >= _endTime;
    }

    // Countdown for breathing or other timing
    public void RunCountDown(string message, int seconds)
    {
        Console.Write($"{message} ");
        for (int i = seconds; i > 0; i--)
        {
            Console.Write($"{i}");
            Thread.Sleep(1000);
            Console.Write("\b \b");
        }
        Console.WriteLine();
    }

    // Spinner animation
    public void DisplaySpinner(string message, int seconds)
    {
        string[] spinner = { "|", "/", "-", "\\" };
        DateTime end = DateTime.Now.AddSeconds(seconds);
        int i = 0;

        if (!string.IsNullOrEmpty(message))
        {
            Console.Write($"{message} ");
        }

        while (DateTime.Now < end)
        {
            Console.Write(spinner[i % spinner.Length]);
            Thread.Sleep(250);
            Console.Write("\b");
            i++;
        }
        Console.WriteLine();
    }

    // Select a random FlaggedString that hasn't been used
    public string GetPromptString(List<FlaggedString> list)
    {
        // Reset if all used
        if (list.TrueForAll(p => p.GetHasBeenUsed()))
        {
            foreach (var p in list)
            {
                p.SetHasBeenUsed(false);
            }
        }

        Random rand = new Random();
        while (true)
        {
            int index = rand.Next(list.Count);
            if (!list[index].GetHasBeenUsed())
            {
                list[index].SetHasBeenUsed(true);
                return list[index].GetPrompt();
            }
        }
    }
}
