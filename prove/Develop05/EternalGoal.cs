using System;

public class EternalGoal : Goal
{
    public EternalGoal() : base("","",0) {}
    public EternalGoal(string name, string description, int points) : base(name, description, points) {}

    public override string GetInformation()
    {
        return "";
    }
    public override void SaveInfo(StreamWriter outputFile)
    {
        outputFile.WriteLine(GetInformation());
    }
}