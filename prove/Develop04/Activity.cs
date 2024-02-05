using System;
using System.Collections.Generic;
using System.Threading;

class Activity
{
    protected string _name;
    protected string _description;
    protected int _duration;

    public Activity(string name, string description, int duration)
    {
        _name = name;
        _description = description;
        _duration = duration;
    }

    public void DisplayStartingMessage()
    {
        Console.WriteLine($"Welcome to the {_name}.");
        Console.WriteLine(_description);
        Console.WriteLine($"Set duration: {_duration} seconds");
        Console.WriteLine("Prepare to begin...");
    
        ShowSpinner(4); 
        Thread.Sleep(2000); 
    }

    public void DisplayEndingMessage()
    {
        Console.WriteLine($"Well done!!");
        Console.WriteLine($"You have completed another {_duration} seconds activity");
        Thread.Sleep(3000);
    }

    public void ShowSpinner(int seconds)
{
    for (int i = 0; i < seconds * 2; i++)
    {
        Console.Write("/");
        Thread.Sleep(250);
        Console.Write("\b");
        Console.Write("-");
        Thread.Sleep(250);
        Console.Write("\b");
        Console.Write("\\");
        Thread.Sleep(250);
        Console.Write("\b");
        Console.Write("|");
        Thread.Sleep(250);
        Console.Write("\b");
    }
}

    public void ShowCountDown(int seconds)
    {
        for (int i = seconds; i > 0; i--)
        {
            Console.Write($"{i} ");
            Thread.Sleep(1000);
            Console.Write("\b\b\b\b");
        }
        Console.WriteLine("Go!");
    }
}