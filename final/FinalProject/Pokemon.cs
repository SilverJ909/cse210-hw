using System;

public class Pokemon
{
    private string _name;
    private string _pokemon;
    private string _type;
    protected string _secondType;
    private string _eggGroup;
    private Ability _ability;
    private Stats _stats;
    protected Entry _entry;
    protected Location _location;
    protected List<string> _types = new List<string>(); 

    public Pokemon()
    {
        _name="";
        _pokemon="";
        _type="";
        _secondType=null;
        _eggGroup="";
    }
    public Pokemon(string name, string pokemon, string eggGroup)
    {
        _name=name;
        _pokemon=pokemon;
        _eggGroup=eggGroup;
        _secondType=null;
    }

    public string GetName()
    {
        return _name;
    }
    public string GetPokemon()
    {
        return _pokemon;
    }
    public string GetType()
    {
        return _type;
    }
    public string GetEggGroup()
    {
        return _eggGroup;
    }

    public void SetType(string type)
    {
        _type = type;
    }

    public virtual void SetTypings()
    {
        _types.Add("Fire");
        _types.Add("Grass");
        _types.Add("Water");
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
        string typeChoice = Console.ReadLine();
        int typeNum = int.Parse(typeChoice);

        _type = _types[typeNum-1];

        Console.Write("Is there a second type (0 for no, 1 for yes): ");
        string forSecondType = Console.ReadLine();
        int choice = int.Parse(forSecondType);

        if (choice == 1)
        {
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
    public virtual string DisplayInformation() 
    {
        if(_secondType == null)
        {
            return $"{typeof(Pokemon)}: No.{_entry.GetEntryNumber()}: {_name} The {_pokemon} pokemon/A {_type} type/Egg Group: {_eggGroup}";
        }
        else{
            return $"{typeof(Pokemon)}: No.{_entry.GetEntryNumber()}:{_name}/The {_pokemon} pokemon/A {_type}/{_secondType} Type/Egg Group: {_eggGroup}";
        }
    }

    public void MakeAbility()
    {
        Console.Write("What is the name of the Pokemon's ability? ");
        string abilityName = Console.ReadLine();

        _ability = new Ability(abilityName);

        _ability.MakeDescription();
    }

    public virtual void SetLocations()
    {
        int i = 0;
        _location = new Location();

        Console.Write("How many locations is this Pokemon in? ");
        string amount = Console.ReadLine();
        int max = int.Parse(amount);

        while(i < max)
        {
            _location.AddALocation();
            i++;
        }
    }

    public void SetStats()
    {
        Console.WriteLine("Now let's determine the pokemon's base stats:");

        Console.Write("Whats the Pokemon's Attack:");
        string stat = Console.ReadLine();
        int attack = int.Parse(stat);

        Console.Write("Whats the Pokemon's Defense:");
        stat = Console.ReadLine();
        int defense = int.Parse(stat);

        Console.Write("Whats the Pokemon's Health:");
        stat = Console.ReadLine();
        int health = int.Parse(stat);

        Console.Write("Whats the Pokemon's Speed:");
        stat = Console.ReadLine();
        int speed = int.Parse(stat);

        Console.Write("Whats the Pokemon's Special Attack:");
        stat = Console.ReadLine();
        int spAttack = int.Parse(stat);

        Console.Write("Whats the Pokemon's Special Defense:");
        stat = Console.ReadLine();
        int spDefense = int.Parse(stat);

        Console.Write("What is the Pokemon's Accuracy:");
        stat = Console.ReadLine();
        int accuracy = int.Parse(stat);

        _stats = new Stats(attack,defense,speed,spAttack,spDefense,accuracy);
        _stats.SetHealth(health);
    }

    public void SaveEntries(StreamWriter outputFile, StreamWriter outputFile2, StreamWriter outputFile3, StreamWriter outputFile4) 
    {
        using (outputFile)
        {
            outputFile.WriteLine(DisplayInformation());
        }
        
        using(outputFile2)
        {
            outputFile2.WriteLine(_entry.DiplayEntry());
        }

        using(outputFile3)
        {
            outputFile3.Write($"No. {_entry.GetEntryNumber()}: ");
            for(int i=0;i<_location.GetCount();i++)
            {
                outputFile3.Write(_location.DisplayLocation(i));
            }
            outputFile3.WriteLine();
        }

        using(outputFile4)
        {
            outputFile4.WriteLine($"No. {_entry.GetEntryNumber()}: {_ability.GetAbilityInfo()}");
        }
    }
}