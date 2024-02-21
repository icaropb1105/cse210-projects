using System;

class Program
{
    static void Main(string[] args)
    {
        Activity runningActivity = new Running(new DateTime(2024, 11, 3), 30, 3.0);
        Activity cyclingActivity = new StationaryBicycle(new DateTime(2024, 11, 3), 30, 12.0); 
        Activity swimmingActivity = new Swimming(new DateTime(2024, 11, 3), 30, 10); 

        var activities = new Activity[] { runningActivity, cyclingActivity, swimmingActivity };

        foreach (var activity in activities)
        {
            Console.WriteLine(activity.GetSummary());
        }
    }
}