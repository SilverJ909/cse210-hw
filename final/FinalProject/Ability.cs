using System;

public class Ability
{
    private string _ability;
    private string _description;

    public Ability(string name)
    {
        _ability = name;
    }

    public void MakeDescription()
    {
        Console.Write($"What is the {_ability}'s description?: ");
        _description = Console.ReadLine();
    }

    public string GetAbilityInfo()
    {
        return $"{_ability}: {_description}";
    }
}