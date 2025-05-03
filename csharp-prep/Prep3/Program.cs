using System;
using System.Net;

class Program
{
    static void Main(string[] args)
    {
        // Magice number
        // Console.WriteLine("What is the magic number? ");
        // int magic_number = int.Parse(Console.ReadLine());
        
        // Generate random magic number
        Random randomGenerator = new Random();
        int magic_number = randomGenerator.Next(1, 100);
        
        // Initialize guess
        int guess = 0;
        // Loop until they guess correctly
        while (guess != magic_number)
        {
            // Guess
            Console.WriteLine("What is your guess? ");
            guess = int.Parse(Console.ReadLine());
            // If
            if (guess > magic_number)
            {
                Console.WriteLine("Lower");
            }
            else if(guess < magic_number)
            {
                Console.WriteLine("Higher");
            }
        }
        Console.WriteLine("You guessed it!");

    }
}