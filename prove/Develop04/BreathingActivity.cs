using System;
using System.ComponentModel;

public class BreathingActivity : Activity
{
    private string _breathIn;
    private string _breathOut;

    public BreathingActivity() : base("Breathing Activity","This activity will help you relax by walking you through breathing in and out slowly. Clear your mind and focus on on your breathing.")
    {
        _breathIn = "Breath In...";
        _breathOut = "Breath Out...";
    }

    public void DisplayBreathIn()
    {
        Console.Write($"{_breathIn}");
    }
    public void DisplayBreathOut()
    {
        Console.Write($"{_breathOut}");
    }
}