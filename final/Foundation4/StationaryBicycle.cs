public class StationaryBicycle : Activity
{
    private double speed;

    public StationaryBicycle(DateTime date, int minutes, double speed)
        : base(date, minutes)
    {
        this.speed = speed;
    }

    public override double GetSpeed()
    {
        return speed;
    }

    public override double GetDistance()
    {
        return (speed / 60) * base.minutes;
    }

    public override double GetPace()
    {
        return 60 / speed;
    }
}