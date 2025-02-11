using System;
using System.Diagnostics;

class Program
{
    static void Main(string[] args)
    {//For Creativity, I added an animation to the Breathing activity that simulates breathing in and out.
    //I also added a safeguard to the user input in the main menu to ensure that the user can only input a valid option.
    
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
                Console.WriteLine("");
                breathingActivity.Run(breathingActivity.GetDuration());
                breathingActivity.DisplayEndingMessage();
            }

            else if (activityChoice == "2")
            {
                ReflectingActivity reflectingActivity = new ReflectingActivity();
                reflectingActivity.DisplayStartingMessage();
                Console.WriteLine("");
                reflectingActivity.Run(reflectingActivity.GetDuration());
                Console.WriteLine("");
                reflectingActivity.DisplayEndingMessage();
            }

            else if (activityChoice == "3")
            {
                ListingActivity listingActivity = new ListingActivity();
                listingActivity.DisplayStartingMessage();
                Console.WriteLine("");
                listingActivity.Run(listingActivity.GetDuration());
                Console.WriteLine("");
                listingActivity.DisplayEndingMessage();
            }

            else if (activityChoice == "4")
            {
                Console.WriteLine("See you next time!");
            }  

            else
            {
                Console.Write("Invalid Entry. Please type '1', '2', '3', or '4'. Hit enter to try again.");
                Console.ReadLine();
            }
        }while (activityChoice != "4");   
    }
}