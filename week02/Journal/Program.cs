using System;
using System.IO;

// I created a new way to save/load files. Rather than having the user input the file name, 
// I have the program automatically save/load to/from a file called "(User's First Name)Journal.txt".
// This way, the user doesn't have to worry about file names and can easily save/load their journal.


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
                Console.WriteLine("Please type your first name: ");
                Console.Write("> ");
                string fileName = Console.ReadLine();
                fileName += "Journal.txt";
                journal.SaveToFile(fileName);
                Console.WriteLine($"Journal saved to {fileName}");
                Console.WriteLine("");
            }

            else if (userChoice == "4")
            {
                Console.WriteLine("Please type your first name: ");
                Console.Write("> ");
                string fileName = Console.ReadLine();
                fileName += "Journal.txt";

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