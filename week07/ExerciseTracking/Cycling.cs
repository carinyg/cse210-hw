public class Cycling : Activity
{
    private int _speed;
    public Cycling(string date, int duration, int speed) : base(date, duration)
    {
        _speed = speed;
    }

    public override float GetDistance()
    {
        float distanceInMiles = _speed * GetDuration() / 60;

        return distanceInMiles;
    }

    public override float GetSpeed()
    {

        return _speed;
    }

    public override float GetPace()
    {
        float paceMinPerMile = GetDuration() / GetDistance();
        return paceMinPerMile;
    }

    public override string GetSummary()
    {
        return $"{GetDate()} Cycling ({GetDuration()} min)- Distance: {GetDistance()} miles, Speed: {GetSpeed()} mph, Pace: {GetPace()} min per mile";
    }
}