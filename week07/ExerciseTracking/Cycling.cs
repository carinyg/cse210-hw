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

    public override float GetSpeed(int duration)
    {
        return 0;
    }

    public override float GetPace(int duration)
    {
        return 0;
    }
}