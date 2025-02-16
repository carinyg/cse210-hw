using System;
using System.IO;

class Program
{
    static void Main(string[] args)
    {
        //For Creativity, I start the program with a welcome message and ask the user for their name
        //I then create a GoalManager object and ask the user if they have used the program before
        //If they have, I load their goals and score, if not, I create a new file for them
        //I removed the loading of goals from the GoalManager start method.
        //I also added a counter to the checkbox of Eternal Goals to show how many times the goal has been completed.
        Console.Clear();
        Console.WriteLine("Welcome to Eternal Quest!");
        Console.WriteLine();
        Console.Write("What is your first name? ");
        string userName = Console.ReadLine();
        GoalManager goalManager = new GoalManager(userName);
        Console.WriteLine();
        Console.Write($"Welcome, {userName}, have you used this program before? (y/n) ");
        string response = Console.ReadLine();

        if (response == "y")
        {
            goalManager.LoadGoals(userName);
            goalManager.LoadScore(userName);
        }
        else
        {
            string fileName = userName + "Journal.txt";
            using (StreamWriter outputFile = new StreamWriter(fileName))
            {
                outputFile.WriteLine("0");
            }
        }

        Console.Clear();
        goalManager.DisplayPlayerInfo();
        Console.WriteLine();
        goalManager.Start(userName);        
    }
}