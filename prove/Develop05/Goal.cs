using System;

public class Goal
{
    private string _goalName;
    private string _description;
    private int _point;
    private bool _isComplete = false;

    public Goal(string name, string description, int points)
    {
        _goalName = name;
        _description = description;
        _point = points; 
    }

    public virtual void SetInformation() 
    {
        Console.Write("What is the name of your goal? ");
        string name = Console.ReadLine();
        _goalName = name;

        Console.Write("What is a short description of it?");
        string description = Console.ReadLine();
        _description = description;

        Console.Write("What is the amount of points associated with this goal? ");
        string points = Console.ReadLine();
        _point = int.Parse(points);
    }

    public virtual string AddCompletedHours()
    {
        return "";
    }
    public virtual string GetInformation() 
    {
        return "";
    }
    public virtual void SaveInfo(StreamWriter outputFile) 
    {
        outputFile.WriteLine(GetInformation());
    }
    public virtual void CompleteGoal()
    {
        _isComplete = true;
    }
    
    public virtual int AddPoints() 
    {
        int total = 0;
        total += _point;
        return total;
    }

    public void SetName(string name)
    {
        _goalName = name;
    }
    public void SetDescription(string description)
    {
        _description = description;
    }
    public void SetPoints(int points)
    {
        _point = points;
    }

    public string GetName()
    {
        return _goalName;
    }
    public string GetDescription()
    {
        return _description;
    }
    public int GetPoints() 
    {
        return _point;
    }
    public void SetComplete(bool completeGoal)
    {
        _isComplete = completeGoal;
    }
    public bool GetComplete()
    {
        return _isComplete;
    }    
}