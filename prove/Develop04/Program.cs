using System;
using System.Threading;

class Program
{
    static void Main(string[] args)
    {
        bool runMenu = true;

        while (runMenu)
        {
            Console.Clear();
            Console.WriteLine("Menu:");
            Console.WriteLine("1. Start Breathing Activity");
            Console.WriteLine("2. Start Reflecting Activity");
            Console.WriteLine("3. Start Listing Activity");
            Console.WriteLine("4. Quit");
            Console.Write("Select a choice from the menu: ");
            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    Breathing breathing = new Breathing();
                    breathing.RunBreathing();
                    Pause();
                    break;

                case "2":
                    ReflectionActivity reflection = new ReflectionActivity();
                    reflection.RunReflectionActivity();
                    Pause();
                    break;

                case "3":
                    ListingActivity listing = new ListingActivity();
                    listing.RunListingActivity();
                    Pause();
                    break;

                case "4":
                    runMenu = false;
                    Console.WriteLine("Goodbye!");
                    break;

                default:
                    Console.WriteLine("Invalid option. Please choose 1–4.");
                    Pause();
                    break;
            }
        }
    }

    static void Pause()
    {
        Console.WriteLine("\nPress Enter to return to the menu...");
        Console.ReadLine();
    }
}
