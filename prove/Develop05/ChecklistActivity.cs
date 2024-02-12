public class ChecklistActivity : Activity
{
    public int TargetCount { get; private set; }
    public int CurrentCount { get; private set; }

    public ChecklistActivity(string name, int points, int targetCount, string description) : base(name, points, description)
    {
        TargetCount = targetCount;
        CurrentCount = 0;
    }

    public override void RecordEvent()
    {
        CurrentCount++;
        Console.WriteLine($"You completed {Name} {CurrentCount}/{TargetCount} times!");
        if (CurrentCount == TargetCount)
        {
            Console.WriteLine($"Congratulations! You achieved the target for {Name} and gained {Points * TargetCount} bonus points.");
        }
        else
        {
            Console.WriteLine($"You gained {Points} points.");
        }
    }

    public override bool IsCompleted()
    {
        return CurrentCount >= TargetCount;
    }
}