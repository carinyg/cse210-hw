public class Running : Activity
{
    public Running(string date, int duration) : base(date, duration)
    {

    }

    public override float GetDistance()
    {
        return 0;
    }

    public override float GetSpeed()
    {
        return 0;
    }

    public override float GetPace()
    {
        return 0;
    }
}