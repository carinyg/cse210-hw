using System;

class Program
{
    static void Main(string[] args)
    {
        Journal journal = new();
        
        while (true)
        {
            Console.WriteLine("1. Create new entry");
            Console.WriteLine("2. Display All Entries");
            Console.WriteLine("3. Save to File");
            Console.WriteLine("4. Load from File");
            Console.WriteLine("5. Quit");

            Console.WriteLine("Enter your selection: ");

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
                Console.WriteLine("Save to File");
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