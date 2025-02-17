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

    public override float GetSpeed(int duration)
    {
        float speedMPH = GetDistance() / duration * 60;
        return speedMPH;
    }

    public override float GetPace(int duration)
    {
        float pace = duration / GetDistance();
        return pace;
    }
}