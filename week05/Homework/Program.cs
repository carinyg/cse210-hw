using System;

class Program
{
    static void Main(string[] args)
    {
        Assignment assignment = new Assignment("Homework 02/05", "Inheritance");
        Console.WriteLine(assignment.GetSummary());
    }
}