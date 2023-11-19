using System;

public class SimpleGoal : Goal
{
    public SimpleGoal() : base("", "", 0) {}
    public SimpleGoal(string name, string description, int points) : base(name, description, points) {}
    public override string GetInformation()
    {
        return $"{typeof(SimpleGoal)}:{GetName()},{GetDescription()},{GetPoints()}";
    }
    public override void SaveInfo(StreamWriter outputFile)
    {
        outputFile.WriteLine(GetInformation());
    }
}