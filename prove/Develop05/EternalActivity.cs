public class EternalActivity : Activity
{
    public EternalActivity(string name, int points, string description) : base(name, points, description)
    {
    
    }

    public override void RecordEvent()
    {
        
    }

    public override bool IsCompleted()
    {
        return false;
    }
}

