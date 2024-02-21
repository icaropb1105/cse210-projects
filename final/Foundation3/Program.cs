using System;

class Program
{
    static void Main(string[] args)
    {
        Address address1 = new Address("123 Main St", "City1", "State1", "Country1");
        Address address2 = new Address("456 Elm St", "City2", "State2", "Country2");

        Event event1 = new Event("Event 1", "Description 1", new DateTime(2024, 2, 25), "10:00 AM", address1);
        Lecture lecture1 = new Lecture("Lecture 1", "Lecture description", new DateTime(2024, 3, 1), "2:00 PM", address2, "Speaker 1", 50);
        Reception reception1 = new Reception("Reception 1", "Reception description", new DateTime(2024, 3, 5), "6:00 PM", address1, "email@example.com");
        OutdoorGathering outdoorGathering1 = new OutdoorGathering("Outdoor Gathering 1", "Outdoor gathering description", new DateTime(2024, 3, 10), "4:00 PM", address2, "Sunny");

        Console.WriteLine("Event 1:");
        Console.WriteLine(event1.GetStandardDetails());
        Console.WriteLine(event1.GetFullDetails());
        Console.WriteLine(event1.GetShortDescription());

        Console.WriteLine("\nLecture 1:");
        Console.WriteLine(lecture1.GetStandardDetails());
        Console.WriteLine(lecture1.GetFullDetails());
        Console.WriteLine(lecture1.GetShortDescription());

        Console.WriteLine("\nReception 1:");
        Console.WriteLine(reception1.GetStandardDetails());
        Console.WriteLine(reception1.GetFullDetails());
        Console.WriteLine(reception1.GetShortDescription());

        Console.WriteLine("\nOutdoor Gathering 1:");
        Console.WriteLine(outdoorGathering1.GetStandardDetails());
        Console.WriteLine(outdoorGathering1.GetFullDetails());
        Console.WriteLine(outdoorGathering1.GetShortDescription());
    }
}