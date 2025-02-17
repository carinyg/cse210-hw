public abstract class Activity
{
    private string _date;
    private string _duration;

    public Activity(string date, string duration)
    {
        _date = date;
        _duration = duration;
    }

    public abstract float GetDistance();

    public abstract float GetSpeed();

    public abstract float GetPace();

    public string GetSummary()
    {
        return "";
    }
}