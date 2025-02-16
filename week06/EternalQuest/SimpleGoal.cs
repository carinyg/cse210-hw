public class SimpleGoal : Goal
{
    private bool _isComplete;

    public SimpleGoal(string name, string description, int points) : base(name, description, points)
    {
        _isComplete = false;
    }

    public SimpleGoal(string name, string description, int points, bool isComplete) : base(name, description, points)
    {
        _isComplete = isComplete;
    }

    public override void RecordEvent()
    {
        Console.WriteLine("Simple goal completed! You're doing a good job!");
        IsComplete();
        Console.WriteLine();

    }
    
    public override bool IsComplete()
    {
        _isComplete = true;
        return _isComplete;
    }

    public override string GetDetailsString()
    {
        if (_isComplete == true)
        {
            return $"[X] {_shortName} ({_description})";
        }
        else
        {
            return $"[ ] {_shortName} ({_description})";
        }
    }

    public override string GetStringRepresentation()
    {
        return $"SimpleGoal,{_shortName},{_description},{_points}, {_isComplete}";
    }
}