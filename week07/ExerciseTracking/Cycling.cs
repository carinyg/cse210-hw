public class Cycling : Activity
{
    private int _speed;
    public Cycling(string date, int duration, int speed) : base(date, duration)
    {
        _speed = speed;
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