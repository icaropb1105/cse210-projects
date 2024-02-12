public abstract class Activity
{
    public string Name { get; protected set; }
    public int Points { get; protected set; }
    public string Description { get; protected set; }

    protected Activity(string name, int points, string description)
    {
        Name = name;
        Points = points;
        Description = description;
    }

    public abstract void RecordEvent();
    public abstract bool IsCompleted(); 
}
