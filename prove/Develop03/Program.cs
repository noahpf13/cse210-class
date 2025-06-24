using System;

class Program
{
    static void Main(string[] args)
    {
        // Define the scripture reference and text
        Reference reference = new Reference("Proverbs", 3, 5, 6);
        string scriptureText = "Trust in the Lord with all thine heart; and lean not unto thine own understanding. In all thy ways acknowledge him, and he shall direct thy paths.";

        // Create a Scripture object
        Scripture scripture = new Scripture(reference, scriptureText);

        // Start the memorization loop
        while (!scripture.AllWordsHidden())
        {
            Console.Clear();
            Console.WriteLine(scripture.GetDisplayText()); 
            Console.WriteLine(); 
            Console.Write("Press Enter to hide more words or type 'quit' to exit: ");

            string input = Console.ReadLine();

            if (input.ToLower() == "quit")
            {
                break;
            }

            scripture.HideRandomWords(3); // Hide 3 random words
        }

        // When done, show final message
        Console.Clear();
        Console.WriteLine("Well done! You've completed the scripture memorization.");
    }
}
