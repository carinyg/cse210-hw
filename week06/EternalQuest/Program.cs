using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Clear();
        Console.WriteLine("Welcome to Eternal Quest!");
        Console.WriteLine();
        Console.WriteLine("What is your first name?");
        string userName = Console.ReadLine();
        GoalManager goalManager = new GoalManager(userName);
        Console.WriteLine();
        Console.Write($"Welcome, {userName}, have you used this program before? (y/n) ");
        string response = Console.ReadLine();

        if (response == "y")
        {
            goalManager.LoadGoals(userName);
        }
        else
        {
            string fileName = userName + "journal.txt";
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