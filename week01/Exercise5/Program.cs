using System;

class Program
{
    static void Main(string[] args)
    {
        DisplayWelcome();
        string name = PromptUserName();
        int number = PromptUserNumber();
        int square = SquareNumber(number);
        DisplayResults(name, square);
    }
    static void DisplayWelcome()
    {
        Console.WriteLine("Welcome to the program!");
    }

    static string PromptUserName()
    {
        Console.Write("Please enter your name: ");
        string name = Console.ReadLine();
        return name;
    }

    static int PromptUserNumber()
    {
        Console.Write("Please enter your favorite number: ");
        string input = Console.ReadLine();
        int number = int.Parse(input);
        return number;       
    }
    
    static int SquareNumber(int number)
    {
        int square = number * number;
        return square;
    }

    static string DisplayResults(string name, int square)
    {
        string message = ($"{name}, the square of your favorite number is {square}.");
        Console.WriteLine(message);
        return message;
    }
}