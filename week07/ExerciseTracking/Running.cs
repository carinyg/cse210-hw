public class Running : Activity
{
    private float _distance;
    public Running(string date, int duration, float distance) : base(date, duration)
    {
        _distance = distance;
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