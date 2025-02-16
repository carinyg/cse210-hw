public class EternalGoal : Goal
{
    private int _completionCount;
    public EternalGoal(string name, string description, int points) : base(name, description, points)
    {
        _completionCount = 0;
    }

    public EternalGoal(string name, string description, int points, int completionCount) : base(name, description, points)
    {
        _completionCount = completionCount;
    }

    public override void RecordEvent()
    {
        Console.Clear();
        _completionCount++;
        Console.WriteLine($"Eternal goal recorded! You've done this goal {_completionCount} times. Good job!");
        Console.WriteLine();
    }

    public override bool IsComplete()
    {
        return false;
    }

    public override string GetDetailsString()
    {
        return $"[{_completionCount}] {_shortName} ({_description})";
    }

    public override string GetStringRepresentation()
    {
        return $"EternalGoal,{_shortName},{_description},{_points}, {_completionCount}";
    }
}