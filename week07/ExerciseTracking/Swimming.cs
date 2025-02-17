public class Swimming : Activity
{
    private int _lapAmount;
    public Swimming(string date, int duration, int lapAmount) : base(date, duration)
    {
        _lapAmount = lapAmount;
    }

    public override float GetDistance()
    {
        float distance = _lapAmount * 50;
        float distanceInMiles = distance / 1000 * 0.62f;
        return distanceInMiles;
    }

    public override float GetSpeed()
    {
        float speedMPH = GetDistance() / GetDuration() * 60;
        return speedMPH;
    }

    public override float GetPace()
    {
        float paceMinPerMile = GetDuration() / GetDistance();
        return paceMinPerMile;
    }

    public override string GetSummary()
    {
        return $"{GetDate()} Swimming ({GetDuration()} min)- Distance: {GetDistance()} miles, Speed: {GetSpeed()} mph, Pace: {GetPace()} min per mile";
    }
}