using System;

public class Starter : Pokemon
{
    private string _professor;

    public Starter(string name, string pokemon, string eggGroup) : base(name, pokemon, eggGroup)
    {
        _professor = "";
    }

    public void SetProfessor()
    {
        Console.Write("What is the name of the Profesor you got it from?");
        _professor = Console.ReadLine();
    }

    public override void SetTypings()
    {
        _types.Add("Fire");
        _types.Add("Grass");
        _types.Add("Water");
        for (int i = 0;i<_types.Count();i++)
        {
            Console.WriteLine($"{i+1}. {_types[i]}");
        }
        Console.Write("What's the type?(answer with the number): ");
        string typeChoice = Console.ReadLine();
        int typeNum = int.Parse(typeChoice);

        SetType(_types[typeNum-1]);

        Console.Write("Is there a second type (0 for no, 1 for yes): ");
        string forSecondType = Console.ReadLine();
        int choice = int.Parse(forSecondType);

        if (choice == 1)
        {
            _types.Add("Electric");
            _types.Add("Normal");
            _types.Add("Bug");
            _types.Add("Flying");
            _types.Add("Rock");
            _types.Add("Ground");
            _types.Add("Psychic");
            _types.Add("Ghost");
            _types.Add("Fighting");
            _types.Add("Ice");
            _types.Add("Dragon");
            _types.Add("Steel");
            _types.Add("Dark");
            _types.Add("Fairy");
            for (int i = 0;i<_types.Count();i++)
            {
                Console.WriteLine($"{i+1}. {_types[i]}");
            }
            Console.Write("What's the type?(answer with the number): ");
            string type2Choice = Console.ReadLine();
            int type2Num = int.Parse(type2Choice);

            _secondType = _types[type2Num-1];
        }
    }

    public override void SetLocations()
    {
        _location = new Location();
        _location._habitats.Add("Unknown");
    }

    public override string DisplayInformation()
    {
        if(_secondType == null)
        {
            return $"{typeof(Starter)}: No.{_entry.GetEntryNumber()}: {GetName()} The {GetPokemon()} pokemon/A {GetType()} type/Egg Group: {GetEggGroup()}/Obtained by Professor {_professor}";
        }
        else{
            return $"{typeof(Starter)}: No.{_entry.GetEntryNumber()}:{GetName()}/The {GetPokemon()} pokemon/A {GetType()}/{_secondType} Type/Egg Group: {GetEggGroup()}/Obtained by Professor {_professor}";
        }
    }
}