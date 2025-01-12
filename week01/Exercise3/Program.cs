using System;

class Program
{
    static void Main(string[] args)
    {
        Random randomGenerator = new Random();
        int number = randomGenerator.Next(1, 101);

        int guess = 0;

        do 
        {
            Console.Write("Guess a number between 1 and 100: ");
            string userInput = Console.ReadLine();
            guess = int.Parse(userInput);

            if (guess < number)
            {
                Console.WriteLine("Higher");
            }
            else if (guess > number)
            {
                Console.WriteLine("Lower");
            }
            else
            {
                Console.WriteLine("You guessed it!");
            }
        } while (number != guess);
    }
}