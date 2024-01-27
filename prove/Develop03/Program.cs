using System;

class Program
{
    static void Main(string[] args)
    {

        // Example scripture: Proverbs 3:5-6
        Reference reference = new Reference("Proverbs", 3, 5, 6);
        Scripture scripture = new Scripture(reference, "Trust in the LORD with all your heart and lean not on your own understanding; in all your ways submit to him, and he will make your paths straight.");

        do
        {
            Console.Clear();
            scripture.Display();
            Console.WriteLine("Press Enter to continue or type 'quit' to exit.");
            string userInput = Console.ReadLine();

            if (userInput.ToLower() == "quit")
                break;

            scripture.HideRandomWords(3); // Hide 3 words at a time
        }
        while (!scripture.IsCompletelyHidden());

        Console.WriteLine("Program ended");
    }
}