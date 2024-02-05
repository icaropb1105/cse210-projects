class BreathingActivity : Activity
{
    public BreathingActivity(int duration) : base("Breathing Activity", "This activity will help you relax by walking you through breathing in and out slowly. Clear your mind and focus on your breathing.", duration) { }

    public void Run()
    {
        DisplayStartingMessage();

        DateTime startTime = DateTime.Now;

        do
        {
            Console.WriteLine("Breathe in...");
            ShowCountDown(3);

            Console.WriteLine("Breathe out...");
            ShowCountDown(3);

        } while ((DateTime.Now - startTime).TotalSeconds < _duration);

        DisplayEndingMessage();
    }
}