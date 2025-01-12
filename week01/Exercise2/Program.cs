using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("What was your grade percentage? ");
        string userInput = Console.ReadLine();
        float gradeReceived = float.Parse(userInput);

        string letter = "";

        if (gradeReceived >= 90)
        {
            letter = "A";
        }
        else if (gradeReceived >= 80)
        {
            letter = "B";
        }
        else if (gradeReceived >= 70)
        {
            letter = "C";
        }
        else if (gradeReceived >= 60)
        {
            letter = "D";
        }
        else
        {
            letter = "F";
        }

        Console.WriteLine($"Your grade is: {letter}");

        if (gradeReceived >= 70)
        {
            Console.WriteLine("You passed! Good job!");
        }
        else
        {
            Console.WriteLine("Not quite there yet. Keep studying! Better luck next time!");
        }
    }
}