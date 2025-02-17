public class Swimming : Activity
{
    private int _lapAmount;
    public Swimming(string date, int duration, int lapAmount) : base(date, duration)
    {
        _lapAmount = lapAmount;
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