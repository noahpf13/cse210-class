using System;
using System.Diagnostics.Tracing;
using System.IO.Compression;

class Program
{
    static void Main()
    {

        int sleepTime = 250;
        int time = 9;

        DateTime currentTime = DateTime.Now;
        DateTime endTime = currentTime.AddSeconds(time);

        string animationString2 = "-+\\/";
        int index = 0;

        while (DateTime.Now < endTime)
        {

            Console.Write(animationString2[index++ % animationString2.Length]);
            Thread.Sleep(sleepTime);
            Console.Write("\b");

        }

        int count = time;

        // while (DateTime.Now < endTime)
        // {
        //     Console.Write(count--); // Takes the number 9 then takes away from it
        //     Thread.Sleep(1000);
        //     Console.Write("\b");

        // }

        string animationString = "(^_^)( *v*)";

        while (DateTime.Now < endTime)
        {

            Console.Write(animationString[0..5]);
            Thread.Sleep(sleepTime);
            Console.Write("\b\b\b\b\b\b");
            Console.Write(animationString[5..]);
            Thread.Sleep(sleepTime);
            Console.Write("\b\b\b\b\b\b");

        }
    }
    





























    // static double AddNumbers(double a, double b)
    // {
    //     return a + b;
    // }
    // static void DisplayGreeting()
    // {
    //     Console.WriteLine("yo");
    // }
    // static void Main(string[] args)

    // {
    //     // int x = 10;
    //     // for(int i = 0; i < x; i++) // initial statement; limit or conditional statement; increment structure of for loop
    //     // {
    //     //     Console.WriteLine("Hello Sandbox World!");
    //     // }



    //     // List<int> myNumbers = new List<int>();

    //     // myNumbers.Add(99);

    //     // foreach(int i in myNumbers)
    //     // {
    //     //             Console.WriteLine(i);

    //     // }
    //     double Total = AddNumbers(255, 643.869);
    //     Console.WriteLine(Total);
    //     Console.WriteLine(AddNumbers(234,432));

    //     DisplayGreeting();

    // }
}