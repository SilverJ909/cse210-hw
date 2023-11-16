using System;

public class Goal
{
    private string _goalName;
    private string _description;
    private int _point;

    public Goal(string name, string description, int points)
    {
        _goalName = name;
        _description = description;
        _point = points; 
    }

    public virtual void SetInformation() {}

    public virtual string GetInformation() 
    {
        return "";
    }
    
    public int AddPoints(int total) 
    {
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
    public string GetPoints() 
    {
        return _point;
    }
}