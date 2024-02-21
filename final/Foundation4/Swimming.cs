public class Swimming : Activity
{
    private int laps;

    public Swimming(DateTime date, int minutes, int laps)
        : base(date, minutes)
    {
        this.laps = laps;
    }

    public override double GetDistance()
    {
        return laps * 50 * 0.62 / 1000; 
    }

    public override double GetSpeed()
    {
        return GetDistance() / minutes * 60;
    }

    public override double GetPace()
    {
        return minutes / GetDistance();
    }

    public override string GetSummary()
    {
        string distance = GetDistance().ToString("0.##", System.Globalization.CultureInfo.InvariantCulture);
        string speed = GetSpeed().ToString("0.##", System.Globalization.CultureInfo.InvariantCulture);
        string pace = GetPace().ToString("0.##", System.Globalization.CultureInfo.InvariantCulture);

        return $"{date.ToShortDateString()} {GetType().Name} ({minutes} min): Distance {distance} miles, Speed {speed} mph, Pace: {pace} min per mile";
    }
}
