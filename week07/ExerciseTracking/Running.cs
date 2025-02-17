public class Running : Activity
{
    private float _distance;
    public Running(string date, int duration, float distance) : base(date, duration)
    {
        _distance = distance;
    }

    public override float GetDistance()
    {
        return _distance;
    }

    public override float GetSpeed()
    {
        float speedMPH = GetDistance() / GetDuration() * 60;
        return speedMPH;
    }

    public override float GetPace()
    {
        float PaceMinPerMile = GetDuration() / GetDistance();
        return PaceMinPerMile;
    }

    public override string GetSummary()
    {
        return $"{GetDate()} Running ({GetDuration()} min)- Distance: {GetDistance()} miles, Speed: {GetSpeed()} mph, Pace: {GetPace()} min per mile";
    }
}