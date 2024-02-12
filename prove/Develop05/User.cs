public class User
{
    public List<Activity> Goals { get; set; }
    public int Score { get; set; }

    public User()
    {
        Goals = new List<Activity>();
        Score = 0;
    }

    public void AddGoal(Activity goal)
    {
        Goals.Add(goal);
    }

    public void RecordGoalCompletion(int index)
    {
        if (index >= 0 && index < Goals.Count)
        {
            Goals[index].RecordEvent();
            Score += Goals[index].Points;
        }
        else
        {
            Console.WriteLine("Invalid goal index.");
        }
    }

    public void DisplayGoals()
{
    Console.WriteLine("\nList of Goals:");
    for (int i = 0; i < Goals.Count; i++)
    {
        string status = "";

        if (Goals[i] is ChecklistActivity checklist)
        {
            status = $" [{(checklist.IsCompleted() ? "X" : " ")}]";
            status += $" ({checklist.CurrentCount}/{checklist.TargetCount} completed)";
        }
        else if (Goals[i] is SimpleActivity simple)
        {
            status = $" [{(simple.IsCompleted() ? "X" : " ")}]";
        }
        else if (Goals[i] is EternalActivity)
        {
            status = " [ ]";
        }

        Console.WriteLine($"{i + 1}. {status} {Goals[i].Name} ({Goals[i].Description})");
    }
}



    public void Save(string filePath)
    {
        using (StreamWriter writer = new StreamWriter(filePath))
        {
            foreach (var goal in Goals)
            {
                writer.WriteLine($"{goal.GetType().Name},{goal.Name},{goal.Points}");
            }
            writer.WriteLine(Score);
        }
    }

    public static User Load(string fileName)
{
    if (!File.Exists(fileName))
    {
        return null;
    }

    using (StreamReader sr = new StreamReader(fileName))
    {
        User user = new User();
        user.Score = int.Parse(sr.ReadLine());

        int count = int.Parse(sr.ReadLine());
        for (int i = 0; i < count; i++)
        {
            string[] parts = sr.ReadLine().Split(';');
            string type = parts[0];
            string name = parts[1];
            int points = int.Parse(parts[2]);
            string description = parts.Length > 3 ? parts[3] : ""; 
            switch (type)
            {
                case "Simple":
                    user.AddGoal(new SimpleActivity(name, points, description));
                    break;
                case "Eternal":
                    user.AddGoal(new EternalActivity(name, points, description));
                    break;
                case "Checklist":
                    int targetCount = int.Parse(parts[3]);
                    user.AddGoal(new ChecklistActivity(name, points, targetCount, description));
                    break;
            }
        }

        return user;
    }
}

}