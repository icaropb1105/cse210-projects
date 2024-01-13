using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("What is your grade percentage? ");
        string answer = Console.ReadLine();
        int grade = int.Parse(answer);

        string letterGrade = "";

        if (grade >= 90)
        {
            letterGrade = "A";
        }

        else if (grade >= 80)
        {
            letterGrade = "B";
        }

        else if (grade >= 70)
        {
            letterGrade = "C";
        }

        else if (grade >= 60)
        {
            letterGrade = "D";
        }

        else 
        {
            letterGrade = "F";
        }

            Console.WriteLine($"Your letter grade is {letterGrade}");
            if (grade > 70)
            {
                Console.WriteLine("Congratulations, you passed!");
            }
            else
            {
                Console.WriteLine("Better luck next time!");
            }
    }
}