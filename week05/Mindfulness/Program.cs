using System;
using System.Diagnostics;

class Program
{
    static void Main(string[] args)
    {
        string activityChoice = "0";
        do
        {
            Console.Clear();
            Console.WriteLine("Menu Options:");
            Console.WriteLine("    1. Start breathing activity");
            Console.WriteLine("    2. Start reflecting activity");
            Console.WriteLine("    3. Start listing activity");
            Console.WriteLine("    4. Quit");
            Console.Write("Type the number of your choice from the menu: ");
            activityChoice = Console.ReadLine();

            if (activityChoice == "1")
            {
               BreathingActivity breathingActivity = new BreathingActivity();
               breathingActivity.DisplayStartingMessage();
               breathingActivity.ShowSpinner(5);
               Console.WriteLine("");
               breathingActivity.Run(breathingActivity.GetDuration());
            }

            else if (activityChoice == "2")
            {

            }

            else if (activityChoice == "3")
            {

            }

            else if (activityChoice == "4")
            {
                Console.WriteLine("See you next time!");
            }  

            else
            {
                Console.Write("Invalid Entry. Please type '1', '2', '3', or '4'.");
                activityChoice = Console.ReadLine();
            }
        }while (activityChoice != "4");

        
    }
}