using System;

public class Pokemon
{
    private string _name;
    private string _pokemon;
    private string _type;
    private string _secondType;
    private string _eggGroup;
    private Ability _ability;
    private Stats _stats;
    private Entry _entry;
    private Location _location;

    public Pokemon(string name, string pokemon, string type, string eggGroup, Ability ability, Stats stats, Entry entry, Location location)
    {
        _name=name;
        _pokemon=pokemon;
        _type=type;
        _eggGroup=eggGroup;
        _ability=ability;
        _stats=stats;
        _entry=entry;
        _location=location;
    }

    public void SetType()
    {
        Console.WriteLine("1. Grass");
        Console.WriteLine("2. Water");
        Console.WriteLine("3. Fire");
    }
}