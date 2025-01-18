using System;

class Program
{
    static void Main(string[] args)
    {
        while (true)
        {
            Console.WriteLine("1. Create new entry");
            Console.WriteLine("2. Display All Entries");
            Console.WriteLine("3. Save to File");
            Console.WriteLine("4. Load from File");
            Console.WriteLine("5. Quit");

            Console.WriteLine("Enter your selection: ");

            string userChoice = Console.ReadLine();

            Console.WriteLine($"You chose {userChoice}");
        }
    }
}