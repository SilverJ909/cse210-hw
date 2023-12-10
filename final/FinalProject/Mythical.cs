using System;

public class Mythical : Pokemon
{
    private string _eventDate;

    public Mythical(string name, string pokemon, string eggGroup, string eventDate) : base(name, pokemon, eggGroup)
    {
        _eventDate = eventDate;
    }

    public override string DisplayInformation()
    {
        if(_secondType == null)
        {
            return $"{typeof(Mythical)}: No.{_entry.GetEntryNumber()}: {GetName()} The {GetPokemon()} pokemon/A {GetType()} type/Egg Group: {GetEggGroup()}/Obtainable on {_eventDate}";
        }
        else{
            return $"{typeof(Mythical)}: No.{_entry.GetEntryNumber()}:{GetName()}/The {GetPokemon()} pokemon/A {GetType()}/{_secondType} Type/Egg Group: {GetEggGroup()}/Obtainable on {_eventDate}";
        }
    }
}