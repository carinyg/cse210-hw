public class GoalManager
{
    private List<Goal> _goals = new List<Goal>();
    private int _score;
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
                ListGoalNames();
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
        Console.WriteLine($"Score: {_score}");
    }

    public void ListGoalNames()
    {}

    public void ListGoalDetails()
    {}

    public void CreateGoal()
    {}

    public void RecordEvent()
    {}

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
    }

    public void LoadGoals(string userName)
    {
        string fileName = userName + "journal.txt";
        string[] lines = System.IO.File.ReadAllLines(fileName);

        foreach (string line in lines)
        {
            string[] parts = line.Split(',');
            string goalType = parts[0];
            string name = parts[1];
            string description = parts[2];
            int points = int.Parse(parts[3]);

            if (goalType == "SimpleGoal")
            {
                _goals.Add(new SimpleGoal(name, description, points));
            }
            else if (goalType == "EternalGoal")
            {
                _goals.Add(new EternalGoal(name, description, points));
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