using System;
using System.Threading;

public class Breathing : BaseActivity
{
    public Breathing()
    : base("Breathing Activity", "This activity will help you relax by walking you through breathing in and out slowly. Clear your mind and focus on your breathing.")
    {
    }

    public void RunBreathing()
    {
        DisplayGreeting();
        DisplayDescription();
        ObtainDuration();
        StartTime();

        Console.Clear();

        Console.WriteLine("Get ready . . .");

        // Set prompts and questions
        // Loop through questions
        // Run for a time, next questions, and so on
        // DisplaySpinner();

        while (!HasTimeExpired())
        {
            RunCountDown("Breathe in . . .", 4);
            RunCountDown("Breathe out . . .", 4);
            Console.WriteLine();
        }

        Console.WriteLine("Well done!!");

        // DisplaySpinner();
        DisplayEnding();
        // DisplaySpinner();



        // Reset Prompts and Questions()

    }
}