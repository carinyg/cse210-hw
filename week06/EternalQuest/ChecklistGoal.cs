public class ChecklistGoal : Goal
{
    private int _amountCompleted;
    private int _target;
    private int _bonus;

    public ChecklistGoal(string name, string description, int points, int target, int bonus) : base(name, description, points)
    {
        _amountCompleted = 0;
        _target = target;
        _bonus = bonus;
    }

    public ChecklistGoal(string name, string description, int points, int target, int bonus, int amountCompleted) : base(name, description, points)
    {
        _amountCompleted = amountCompleted;
        _target = target;
        _bonus = bonus;
    }

    public override void RecordEvent()
    {
        Console.Clear();
        Console.WriteLine("Checklist goal recorded! You're doing a good job!");
        _amountCompleted++;
        Console.WriteLine();
        if (_amountCompleted == _target)
        {
            Console.WriteLine($"Congratulations! You've completed the goal! You've earned {_bonus} bonus points!");
            _points += _bonus;
        }
    }

    public override bool IsComplete()
    {
        if (_amountCompleted == _target)
        {
            return true;
        }
        else
        {
            return false;
        }
    }

    public override string GetDetailsString()
    {
        if (IsComplete())
        {
            return $"[X] {_shortName} ({_description} -- Currently completed: {_amountCompleted}/{_target})";
        }
        else
        {
            return $"[ ] {_shortName} ({_description}) -- Currently completed: {_amountCompleted}/{_target}";
        }
    }

    public override string GetStringRepresentation()
    {
        return $"ChecklistGoal,{_shortName},{_description},{_points},{_target},{_bonus}, {_amountCompleted}";
    }
}