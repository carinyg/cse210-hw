using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;

class Program
{
    static void Main(string[] args)
    {
        List<int> numbers = new List<int>();

        Console.WriteLine("Enter a list of numbers, type 0 when finished.");

        int number = 0;

        do
        {
            Console.Write("Enter a number: ");
            string input = Console.ReadLine();
            number = int.Parse(input);

            numbers.Add(number);
        } while (number != 0);

        int sum = 0;

        foreach (int num in numbers)
        {
            sum = sum + num;
        }

        Console.WriteLine($"The sum is: {sum}");

        float average = ((float)sum) / (numbers.Count - 1);

        Console.WriteLine($"The average is: {average}");

        int largest = 0;

        foreach (int num in numbers)
        {
            if (num > largest)
            {
                largest = num;
            }
        }

        Console.WriteLine($"The largest number is: {largest}");


    }
}