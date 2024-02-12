using System;
using System.Collections.Generic;
using System.IO;
//added methods to check if it's a Invalid choice
public class Program
{
    static void Main(string[] args)
    {
        User user = User.Load("user.txt");

        if (user == null)
        {
            user = new User();
            InitializeGoals(user);
        }

        Console.WriteLine("Welcome to Eternal Quest!");

        while (true)
        {
            Console.WriteLine($"\nPoints: {user.Score}");
            Console.WriteLine("\n1. Record Goal Completion");
            Console.WriteLine("2. Display Goals");
            Console.WriteLine("3. Create New Goal");
            Console.WriteLine("4. Save");
            Console.WriteLine("5. Load");
            Console.WriteLine("6. Quit");
            Console.Write("\nEnter your choice: ");
            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    RecordGoalCompletion(user);
                    break;
                case "2":
                    user.DisplayGoals();
                    break;
                case "3":
                    CreateNewGoal(user);
                    break;
                case "4":
                    user.Save("user.txt");
                    Console.WriteLine("User data saved.");
                    break;
                case "5":
                    user = User.Load("user.txt");
                    Console.WriteLine("User data loaded.");
                    break;
                case "6":
                    Console.WriteLine("Goodbye!");
                    return;
                default:
                    Console.WriteLine("Invalid choice. Please enter a number from 1 to 6.");
                    break;
            }
        }
    }

    static void InitializeGoals(User user)
    {

    }

    static void RecordGoalCompletion(User user)
    {
        user.DisplayGoals();
        Console.Write("Enter the index of the goal you completed: ");
        if (int.TryParse(Console.ReadLine(), out int index))
        {
            user.RecordGoalCompletion(index - 1);
        }
        else
        {
            Console.WriteLine("Invalid input. Please enter a number.");
        }
    }

    static void CreateNewGoal(User user)
{
    Console.WriteLine("Select the type of goal:");
    Console.WriteLine("1. Simple");
    Console.WriteLine("2. Eternal");
    Console.WriteLine("3. Checklist");
    Console.Write("Enter your choice: ");
    string choice = Console.ReadLine();
    string description = "";

    if (int.TryParse(choice, out int menuChoice))
    {
        Console.Write("Enter the name of the new goal: ");
        string name = Console.ReadLine();
        Console.Write("Enter a brief description for the goal: ");
        description = Console.ReadLine();

        switch (menuChoice)
        {
            case 1:
                Console.Write("Enter the points for the new goal: ");
                if (int.TryParse(Console.ReadLine(), out int simplePoints))
                {
                    user.AddGoal(new SimpleActivity(name, simplePoints, description));
                    Console.WriteLine("New simple goal created.");
                }
                else
                {
                    Console.WriteLine("Invalid input for points. Goal creation aborted.");
                }
                break;
            case 2:
                Console.Write("Enter the points for the new goal: ");
                if (int.TryParse(Console.ReadLine(), out int eternalPoints))
                {
                    user.AddGoal(new EternalActivity(name, eternalPoints, description));
                    Console.WriteLine("New eternal goal created.");
                }
                else
                {
                    Console.WriteLine("Invalid input for points. Goal creation aborted.");
                }
                break;
            case 3:
                Console.Write("Enter the points for the new goal: ");
                if (int.TryParse(Console.ReadLine(), out int checklistPoints))
                {
                    Console.Write("Enter the target count for the checklist: ");
                    if (int.TryParse(Console.ReadLine(), out int targetCount))
                    {
                        user.AddGoal(new ChecklistActivity(name, checklistPoints, targetCount, description));
                        Console.WriteLine("New checklist goal created.");
                    }
                    else
                    {
                        Console.WriteLine("Invalid input for target count. Goal creation aborted.");
                    }
                }
                else
                {
                    Console.WriteLine("Invalid input for points. Goal creation aborted.");
                }
                break;
            default:
                Console.WriteLine("Invalid choice. Goal creation aborted.");
                break;
        }
    }
    else
    {
        Console.WriteLine("Invalid input. Please enter a number.");
    }
}


}