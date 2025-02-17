public abstract class Activity
{
    private string _date;
    private int _duration;

    public Activity(string date, int duration)
    {
        _date = date;
        _duration = duration;
    }

    public abstract float GetDistance();

    public abstract float GetSpeed();

    public abstract float GetPace();

    public virtual string GetSummary()
    {
        return $"{GetDate()} Activity ({GetDuration()} min)- Distance: {GetDistance()} miles, Speed: {GetSpeed()} mph, Pace: {GetPace()} min per mile";
    }

    public int GetDuration()
    {
        return _duration;
    }

    public string GetDate()
    {
        return _date;
    }
}