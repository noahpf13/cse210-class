using System;

class Program
{
    static void Main(string[] args)
    {
        bool runMenu = true;
        Journal journal = new Journal();

        while (runMenu)
        {
            Console.WriteLine("Menu:");
            Console.WriteLine("1. Write");
            Console.WriteLine("2. Display ");
            Console.WriteLine("3. Save");
            Console.WriteLine("4. Load");
            Console.WriteLine("5. Exit");
            Console.Write("What would you like to do? ");
            string input = Console.ReadLine();

            switch (input)
            {
                case "1":
                    journal.WriteEntry();
                    break;
                case "2":
                    journal.DisplayJournal();
                    break;
                case "3":
                    journal.SaveJournal();
                    break;
                case "4":
                    journal.LoadJournal();
                    break;
                case "5":
                    runMenu = false;
                    Console.WriteLine("Goodbye!");
                    break;
                default:
                    Console.WriteLine("Invalid option. Please choose 1–5.");
                    break;
            }

        }
    }
}
