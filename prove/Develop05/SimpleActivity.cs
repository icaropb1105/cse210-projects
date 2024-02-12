public class SimpleActivity : Activity
{
    private bool completed;

    public SimpleActivity(string name, int points, string description) : base(name, points, description)
    {
        completed = false;
    }

    public override void RecordEvent()
    {
        completed = true; 
        Console.WriteLine($"Congratulations! You completed the {Name} goal and gained {Points} points.");
    }

    public override bool IsCompleted()
    {
        return completed; 
    }
}