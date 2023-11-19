using System;

public class ChecklistGoal : Goal
{
    private int _hoursNeeded;
    private int _bonus;
    private int _hoursComplete;

    public ChecklistGoal() : base("","",0) 
    {
        _hoursNeeded = 0;
        _bonus = 0;
        _hoursComplete = 0;
    }
    public ChecklistGoal(string name, string description, int points) : base(name,description,points) 
    {
        _hoursNeeded = 0;
        _bonus = 0;
        _hoursComplete = 0;
    }

    public override void SetInformation()
    {
        Console.Write("What is the name of your goal? ");
        string name = Console.ReadLine();
        SetName(name);

        Console.Write("What is a short description of it?");
        string description = Console.ReadLine();
        SetDescription(description);

        Console.Write("What is the amount of points associated with this goal? ");
        string points = Console.ReadLine();
        SetPoints(int.Parse(points));

        Console.Write("How many times does this goal nee to be accomplished for a bonus? ");
        string hours = Console.ReadLine();
        _hoursNeeded = int.Parse(hours);

        Console.Write("What is the bonus for accomplishing it that many times? ");
        string bonus = Console.ReadLine();
        _bonus = int.Parse(bonus);
    }
    public override string GetInformation()
    {
        return $"{typeof(ChecklistGoal)}:{GetName()},{GetDescription()},{GetPoints()},{_bonus},{_hoursNeeded},{_hoursComplete}";
    }
    public override void SaveInfo(StreamWriter outputFile)
    {
        outputFile.WriteLine(GetInformation());
    }
    public override void CompleteGoal()
    {
        _hoursComplete++;
        if(_hoursComplete >= _hoursNeeded)
        {
            SetComplete(true);
        }
    }
    public override int AddPoints()
    {
        int total = 0;
        total+=GetPoints();
        if (_hoursComplete == _hoursNeeded)
        {
            total += _bonus;
        }
        return total;
    }
    public override string AddCompletedHours()
    {
        return $" -- Currently completed: {_hoursComplete}/{_hoursNeeded}";
    }
}