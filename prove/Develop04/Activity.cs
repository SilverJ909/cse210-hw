using System;

public class Activity
{
    private string _activityName;
    private string _description;
    private int _duration;

    public Activity(string name, string description)
    {
        _activityName = name;
        _description = description;
    }

    public void UserSetDuration()
    {
        Console.Write("How long would you like to do this activity? ");
        string time = Console.ReadLine();
        _duration = int.Parse(time);
    }
    public void DisplayStartMessage()
    {
        Console.WriteLine($"Welcome to the {_activityName}\n");
        Console.WriteLine($"{_description}\n");
        Console.Write("How long, in seconds, would you like for your session? ");
        string duration = Console.ReadLine();
        _duration = int.Parse(duration);
    }
    public void DisplayEndMessage()
    {
        Console.WriteLine("Well done!!\n");
        PauseWithSpinner();
        Console.WriteLine();
        Console.WriteLine($"You have completed another {_duration} seconds of the {_activityName}.");
        PauseWithSpinner();
    }
    public void PauseWithTimer(int duration)
    {
        for (int i=duration;i>0;i--)
        {
            Console.Write(i);
            Console.Write("\b");
            Thread.Sleep(1000);
        }
        Console.Write(" \b");
        Console.WriteLine();
    }
    public void PauseWithSpinner()
    {
        Console.Write("|");
        Thread.Sleep(200);
        Console.Write("\b \b");
        Console.Write("/");
        Thread.Sleep(200);
        Console.Write("\b \b");
        Console.Write("-");
        Thread.Sleep(200);
        Console.Write("\b \b");
        Console.Write("\\");
        Thread.Sleep(200);
        Console.Write("\b \b");
        Console.Write("|");
        Thread.Sleep(200);
        Console.Write("\b \b");
        Console.Write("/");
        Thread.Sleep(200);
        Console.Write("\b \b");
        Console.Write("-");
        Thread.Sleep(200);
        Console.Write("\b \b");
        Console.Write("\\");
        Thread.Sleep(200);
        Console.Write("\b \b");
    }
    public void GetReady()
    {
        Console.WriteLine("Get ready...");
        PauseWithSpinner();
    }

    public int GetDuration()
    {
        return _duration;
    }
}