using System;

class Program
{
    static void Main(string[] args)
    {
        Journal journal = new();

        Console.WriteLine("Welcome to the Journal Program!");
        
        while (true)
        {
            Console.WriteLine("Please select one of the following choices: ");
            Console.WriteLine("1. Write an Entry");
            Console.WriteLine("2. Display All Entries");
            Console.WriteLine("3. Save to a File");
            Console.WriteLine("4. Load from a File");
            Console.WriteLine("5. Quit");

            Console.Write("Which would you like to do? ");

            string userChoice = Console.ReadLine();

            if (userChoice == "1")
            {
                journal.AddEntry();
            }

            else if (userChoice == "2")
            {
                journal.DisplayAll();
            }

            else if (userChoice == "3")
            {
                journal.SaveToFile("journal.txt");
            }

            else if (userChoice == "4")
            {
                Console.WriteLine("Load from File");
            }

            else if (userChoice == "5")
            {
                return;
            }

            else
            {
                Console.WriteLine("Invalid choice. Please try again.");
            }
        }
    }
}