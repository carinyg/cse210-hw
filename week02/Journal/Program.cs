using System;
using System.IO;

class Program
{
    static void Main(string[] args)
    {
        Journal journal = new();

        Console.WriteLine("");
        Console.WriteLine("Welcome to the Journal Program!");
        Console.WriteLine("");
        
        while (true)
        {
            Console.WriteLine("Please select one of the following choices: ");
            Console.WriteLine("1. Write an Entry");
            Console.WriteLine("2. Display All Entries");
            Console.WriteLine("3. Save to a File");
            Console.WriteLine("4. Load from a File");
            Console.WriteLine("5. Quit");

            Console.WriteLine("Which would you like to do? ");
            Console.Write("> ");
            
            string userChoice = Console.ReadLine();

            Console.WriteLine("");

            if (userChoice == "1")
            {
                journal.AddEntry();
            }

            else if (userChoice == "2")
            {
                journal.DisplayAll();
                Console.WriteLine("");
            }

            else if (userChoice == "3")
            {
                Console.WriteLine("Choose a file name ending in .txt to save your journal to: ");
                Console.Write("> ");
                string fileName = Console.ReadLine();
                journal.SaveToFile(fileName);
                Console.WriteLine($"Journal saved to {fileName}");
                Console.WriteLine("");
            }

            else if (userChoice == "4")
            {
                Console.WriteLine("Choose a file to load your journal from: ");
                Console.Write("> ");
                string fileName = Console.ReadLine();

                List<Entry> newEntry = Journal.LoadFromFile(fileName);

                foreach (Entry e in newEntry)
                {
                    journal._entries.Add(e);
                }
                Console.WriteLine($"Journal loaded from {fileName}");
                Console.WriteLine("");
                

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