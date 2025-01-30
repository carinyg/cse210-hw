using System;
using System.Security.Cryptography;
using System.Xml.Serialization;

class Program
{
    static void Main(string[] args)
    {//For creativity I added the option to add your own scripture reference and text to memorize.
    
        Console.Clear();
        Console.WriteLine("Welcome to the Scripture Memorizer!");
        Console.WriteLine("Would you like to memorize: ");
        Console.WriteLine("1. James 1:5");
        Console.WriteLine("2. or Add your own scripture reference?");
        Console.WriteLine("Type '1', '2', or 'quit' to finish.");
        string choice = Console.ReadLine();

        if (choice == "1")
        {
            Reference r1 = new Reference("James", 1, 5);
            Scripture s1 = new Scripture(r1,"If any of you lack wisdom, let him ask of God, that giveth to all men liberally, and upbraideth not; and it shall be given him."); 
            string input = ""; 
        
            while (input != "quit")
            {
                Console.Clear();
                string reference = r1.GetDisplayText();
                string scripture = s1.GetDisplayText();
                Console.WriteLine($"{reference} {scripture}");
                Console.WriteLine("Press enter to continue or type 'quit' to finish:");
                input = Console.ReadLine();
                s1.HideRandomWords(3);
                bool hidden = s1.IsCompletelyHidden();
                if (hidden == true)
                {
                    Console.WriteLine("Congratulations! You have successfully memorized the scripture!");
                    break;
                }
            }

            if (input == "quit")
            {
                Console.WriteLine("Goodbye!");
            }
        }

        else if (choice == "2")
        {
            Console.WriteLine("Enter the book name:");
            string book = Console.ReadLine();
            Console.WriteLine("Enter the chapter number:");
            int chapter = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the beginning verse number:");
            int startVerse = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the ending verse number (if your selection is one verse please repeat beginning verse):");
            int endVerse = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the scripture text:");
            string text = Console.ReadLine();

            if (startVerse == endVerse)
            {
                Reference r1 = new Reference(book, chapter, startVerse);
                Scripture s1 = new Scripture(r1, text);

                string input = ""; 
        
                while (input != "quit")
                {
                    Console.Clear();
                    string reference = r1.GetDisplayText();
                    string scripture = s1.GetDisplayText();
                    Console.WriteLine($"{reference} {scripture}");
                    Console.WriteLine("Press enter to continue or type 'quit' to finish:");
                    input = Console.ReadLine();
                    s1.HideRandomWords(3);
                    bool hidden = s1.IsCompletelyHidden();
                    if (hidden == true)
                    {
                        Console.WriteLine("Congratulations! You have successfully memorized the scripture!");
                        break;
                    }
                }

                if (input == "quit")
                {
                    Console.WriteLine("Goodbye!");
                }
            }

            else
            {
                Reference r1 = new Reference(book, chapter, startVerse, endVerse);
                Scripture s1 = new Scripture(r1, text);
                 string input = ""; 
        
                while (input != "quit")
                {
                    Console.Clear();
                    string reference = r1.GetDisplayText();
                    string scripture = s1.GetDisplayText();
                    Console.WriteLine($"{reference} {scripture}");
                    Console.WriteLine("Press enter to continue or type 'quit' to finish:");
                    input = Console.ReadLine();
                    s1.HideRandomWords(3);
                    bool hidden = s1.IsCompletelyHidden();
                    if (hidden == true)
                    {
                        Console.WriteLine("Congratulations! You have successfully memorized the scripture!");
                        break;
                    }
                }

                if (input == "quit")
                {
                    Console.WriteLine("Goodbye!");
                }
            }
        }
        else if (choice == "quit")
        {
            Console.WriteLine("Goodbye!");
        }
        else
        {
            Console.WriteLine("Invalid choice. Goodbye!");
        }
       

          
    }
}