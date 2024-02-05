class ReflectingActivity : Activity
{
    private List<string> _prompts;
    private List<string> _questions;

    public ReflectingActivity(int duration) : base("Reflection Activity", "This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.", duration)
    {
        _prompts = new List<string>
        {
            "Think of a time when you stood up for someone else.",
            "Think of a time when you did something really difficult.",
            "Think of a time when you helped someone in need.",
            "Think of a time when you did something truly selfless."
        };

        _questions = new List<string>
        {
            "Why was this experience meaningful to you?",
            "Have you ever done anything like this before?",
            "How did you get started?",
            "How did you feel when it was complete?",
            "What made this time different than other times when you were not as successful?",
            "What is your favorite thing about this experience?",
            "What could you learn from this experience that applies to other situations?",
            "What did you learn about yourself through this experience?",
            "How can you keep this experience in mind in the future?"
        };
    }

    public void Run()
{
    DisplayStartingMessage();

    string initialPrompt = GetRandomPrompt();
    Console.WriteLine(initialPrompt);
    Console.WriteLine("Press Enter when you are ready to start reflecting...");
    Console.ReadLine(); 

    DateTime startTime = DateTime.Now;

    do
    {
        string question = GetRandomQuestion();
        Console.WriteLine(question);

        // Display spinner animation
        ShowSpinner(4); 
        Thread.Sleep(4000); 

    } while ((DateTime.Now - startTime).TotalSeconds < _duration);

    DisplayEndingMessage();
}


    private string GetRandomPrompt()
    {
        Random random = new Random();
        return _prompts[random.Next(_prompts.Count)];
    }

    private string GetRandomQuestion()
    {
        Random random = new Random();
        return _questions[random.Next(_questions.Count)];
    }
}
