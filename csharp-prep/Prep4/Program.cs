using System;
using System.Collections.Generic;
using System.Net;


class Program
{
    static void Main(string[] args)
    {
        // List<string> words = new List<string>();

        // words.Add("phone");
        // words.Add("keyboard");
        // words.Add("mouse");

        // for (int i = 0; i < words.Count; i++)
        // {
        // Console.WriteLine(words[i]);
        // }
        
        // Create list of numbers
        List<int> numbers = new List<int>();
        // Create while loop for user 
        int response = -1;

        Console.WriteLine("Enter a list of numbers, type 0 hen finished.");
        
        while (response != 0)
        {
            Console.WriteLine("Enter number: ");
            response = int.Parse(Console.ReadLine());
            
            numbers.Add(response);
        }
        int sum = numbers.Sum();
        double avg = numbers.Average();
        int max = numbers.Max();

        Console.WriteLine("The sum is: " + sum);
        Console.WriteLine("The average is: " + avg);
        Console.WriteLine("The largest number is: " + max);


    }
}