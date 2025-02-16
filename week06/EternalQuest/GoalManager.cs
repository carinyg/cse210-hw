using System.IO;
using Microsoft.Win32.SafeHandles;
public class GoalManager
{
    private List<Goal> _goals = new List<Goal>();
    private int _score = 0;
    private string _userName;

    public GoalManager(string userName)
    {
        _goals = new List<Goal>();
        _score = 0;
        _userName = userName;
    }
    

    public void Start(string userName)
    {
        string choice = "0";
        do
        {
            Console.WriteLine("Menu Options:");
            Console.WriteLine("  1. Create New Goal");
            Console.WriteLine("  2. List Goals");
            Console.WriteLine("  3. Save Goals");
            Console.WriteLine("  4. Load Goals");
            Console.WriteLine("  5. Record Event");
            Console.WriteLine("  6. Quit");
            Console.Write("Select a choice from the menu: ");
            choice = Console.ReadLine();
            Console.WriteLine();

            if (choice == "1")
            {
                CreateGoal();
            }
            else if (choice == "2")
            {
                ListGoalDetails();
            }
            else if (choice == "3")
            {
                SaveGoals(userName);
            }
            else if (choice == "4")
            {
                LoadGoals(userName);
            }
            else if (choice == "5")
            {
                RecordEvent();
            }
            else if (choice == "6")
            {
                Console.WriteLine("Good luck with your Eternal Quest! See you next time!");
                Console.WriteLine();
            }
            else
            {
                Console.WriteLine("Invalid choice. Please try again.");
                Console.WriteLine("Press any key to continue...");
            }
        } while (choice != "6");
    }

    public void DisplayPlayerInfo()
    {
        Console.WriteLine($"Player: {_userName}");
        LoadScore(_userName);
        Console.WriteLine($"Score: {_score}");
    }

    public void ListGoalNames()
    {
        int count = 1;
        foreach (Goal goal in _goals)
        {
           Console.WriteLine($"{count}. {goal.GetName()}");
        }
    }

    public void ListGoalDetails()
    {
        int count = 1;
        foreach (Goal goal in _goals)
        {
            Console.WriteLine($"{count}. {goal.GetDetailsString()}");
            count++;
        }
    }

    public void CreateGoal()
    {
        Console.WriteLine("There are three types of goals:");
        Console.WriteLine("  1. Simple Goal");
        Console.WriteLine("  2. Eternal Goal");
        Console.WriteLine("  3. Checklist Goal");
        Console.Write("Please select a goal type: ");
        string goalChoice = Console.ReadLine();
        Console.Clear();
        Console.Write("What is the name of the goal? ");
        string name = Console.ReadLine();
        Console.Write("What is a short description of the goal? ");
        string description = Console.ReadLine();
        Console.Write("How many points is the goal worth? ");
        int points = int.Parse(Console.ReadLine());

        if (goalChoice == "1")
        {
            _goals.Add(new SimpleGoal(name, description, points));
        }
        else if (goalChoice == "2")
        {
            _goals.Add(new EternalGoal(name, description, points));
        }
        else if (goalChoice == "3")
        {
            Console.Write("How many times must the goal be completed to reach the target? ");
            int target = int.Parse(Console.ReadLine());
            Console.Write("How many bonus points are awarded for reaching the target? ");
            int bonus = int.Parse(Console.ReadLine());
            _goals.Add(new ChecklistGoal(name, description, points, target, bonus));
        }
        Console.WriteLine();
        Console.WriteLine("Goal created successfully!");
        Console.Clear();
    }

    public void RecordEvent()
    {
        Console.WriteLine("Which goal would you like to record an event for?");
        ListGoalNames();
        Console.Write("Select a goal: ");
        int goalChoice = int.Parse(Console.ReadLine());
        _goals[goalChoice - 1].RecordEvent();
        _score += _goals[goalChoice - 1].GetPoints();
        Console.WriteLine();
        Console.WriteLine("Event recorded successfully!");
        Console.Clear();
    }

    public void SaveGoals(string userName)
    {
        string fileName = userName + "journal.txt";
        using (StreamWriter outputFile = new StreamWriter(fileName))
        {
            outputFile.WriteLine(_score);
            foreach (Goal goal in _goals)
            {
                outputFile.WriteLine(goal.GetStringRepresentation());
            }
        }
        Console.WriteLine($"{userName}'s goals have been saved to {fileName}.");
    }

    public void LoadScore(string userName)
    {
        string fileName = userName + "journal.txt";
        using (StreamReader file = new StreamReader(fileName))
        {
            _score = int.Parse(file.ReadLine());
        }
    }

    public void LoadGoals(string userName)
    {
        string fileName = userName + "journal.txt";

        using (StreamReader file = new StreamReader(fileName))
        {
            file.ReadLine();
            string line;
            while ((line = file.ReadLine()) != null)
            {
                string[] parts = line.Split(',');
                string goalType = parts[0];
                string name = parts[1];
                string description = parts[2];
                int points = int.Parse(parts[3]);

                if (goalType == "SimpleGoal")
                {
                    string isComplete = parts[4];
                    _goals.Add(new SimpleGoal(name, description, points, bool.Parse(isComplete)));
                }
                else if (goalType == "EternalGoal")
                {
                    int completionCount = int.Parse(parts[4]);
                    _goals.Add(new EternalGoal(name, description, points, completionCount));
                }
                else if (goalType == "ChecklistGoal")
                {
                    int target = int.Parse(parts[4]);
                    int bonus = int.Parse(parts[5]);
                    _goals.Add(new ChecklistGoal(name, description, points, target, bonus));
                }
            }
        }
    }
}