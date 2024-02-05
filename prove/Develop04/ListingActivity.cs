class ListingActivity : Activity
{
    private int _count;
    private List<string> _prompts;

    public ListingActivity(int duration) : base("Listing Activity", "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.", duration)
    {
        _count = 0;
        _prompts = new List<string>
        {
            "Who are people that you appreciate?",
            "What are personal strengths of yours?",
            "Who are people that you have helped this week?",
            "When have you felt the Holy Ghost this month?",
            "Who are some of your personal heroes?"
        };
    }

    public void Run()
    {
        DisplayStartingMessage();

        DateTime startTime = DateTime.Now;

         string prompt = GetRandomPrompt();

    Console.WriteLine($"List as many responses as you can to the following prompt: {prompt}");

    Console.WriteLine("Start listing...");

        do
        {
            Console.ReadLine();
            _count++;

        } while ((DateTime.Now - startTime).TotalSeconds < _duration);

        Console.WriteLine($"Number of items entered: {_count}");
        DisplayEndingMessage();
    }
    private string GetRandomPrompt()
    {
        Random random = new Random();
        return _prompts[random.Next(_prompts.Count)];
    }

}