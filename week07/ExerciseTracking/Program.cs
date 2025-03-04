using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Clear();
        List<Activity> _activities = new List<Activity>();
        _activities.Add(new Running("17 Feb 2025", 30, 3.0f));
        _activities.Add(new Cycling("17 Feb 2025", 45, 20));
        _activities.Add(new Swimming("17 Feb 2025", 60, 20));

        foreach (Activity activity in _activities)
        {
            Console.WriteLine(activity.GetSummary());
            Console.WriteLine();
        }
    }
}