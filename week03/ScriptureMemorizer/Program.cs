using System;
using System.Security.Cryptography;
using System.Xml.Serialization;

class Program
{
    static void Main(string[] args)
    {
        Reference r1 = new Reference("James", 1, 5, 6);

        Scripture s1 = new Scripture(r1,"If any of you lack wisdom, let him ask of God, that giveth to all men liberally, and upbraideth not; and it shall be given him. But let him ask in faith, nothing wavering. For he that wavereth is like a wave of the sea driven with the wind and tossed.");
        
        bool hidden = s1.IsCompletelyHidden();
        string input = "";  
        
        while ((input != "quit") || (hidden == false))
        {
            Console.Clear();
            string reference = r1.GetDisplayText();
            string scripture = s1.GetDisplayText();
            Console.WriteLine($"{reference} {scripture}");
            Console.WriteLine("Press enter to continue or type 'quit' to finish:");
            input = Console.ReadLine();
            s1.HideRandomWords(3);
            hidden = s1.IsCompletelyHidden();
        }

        if (hidden == true)
        {
            Console.WriteLine("Congratulations! You have successfully memorized the scripture!");
        }

        if (input == "quit")
        {
            Console.WriteLine("Goodbye!");
        }   
    }
}