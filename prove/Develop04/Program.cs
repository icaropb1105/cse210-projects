class Program
{
    static void Main()
    {
        Console.WriteLine("Menu Options:");

        int choice;
        do
        {
            Console.WriteLine("1. Breathing Activity");
            Console.WriteLine("2. Reflection Activity");
            Console.WriteLine("3. Listing Activity");
            Console.WriteLine("4. Quit");

            Console.Write("Choose an activity (1-4): ");
            choice = int.Parse(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    Console.Write("Enter the duration in seconds: ");
                    int breathingDuration = int.Parse(Console.ReadLine());
                    BreathingActivity breathingActivity = new BreathingActivity(breathingDuration);
                    breathingActivity.Run();
                    break;
                case 2:
                    Console.Write("Enter the duration in seconds: ");
                    int reflectingDuration = int.Parse(Console.ReadLine());
                    ReflectingActivity reflectingActivity = new ReflectingActivity(reflectingDuration);
                    reflectingActivity.Run();
                    break;
                case 3:
                    Console.Write("Enter the duration in seconds: ");
                    int listingDuration = int.Parse(Console.ReadLine());
                    ListingActivity listingActivity = new ListingActivity(listingDuration);
                    listingActivity.Run();
                    break;
                case 4:
                    Console.WriteLine("Exiting program. Goodbye!");
                    break;
                default:
                    Console.WriteLine("Invalid choice. Please try again.");
                    break;
            }

        } while (choice != 4);
    }
}