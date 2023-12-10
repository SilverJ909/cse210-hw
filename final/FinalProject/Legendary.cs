using System;

public class Legendary : Pokemon
{
    public Legendary(string name, string pokemon, string eggGroup) : base(name, pokemon, eggGroup) {}

    public override void SetLocations()
    {
        _location = new Location();
        _location._habitats.Add("Unknown");
    }

    public override string DisplayInformation()
    {
        if(_secondType == null)
        {
            return $"{typeof(Legendary)}: No.{_entry.GetEntryNumber()}: {GetName()} The {GetPokemon()} pokemon/A {GetType()} type/Egg Group: {GetEggGroup()}";
        }
        else{
            return $"{typeof(Legendary)}: No.{_entry.GetEntryNumber()}:{GetName()}/The {GetPokemon()} pokemon/A {GetType()}/{_secondType} Type/Egg Group: {GetEggGroup()}";
        }
    }
}