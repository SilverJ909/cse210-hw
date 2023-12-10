using System;
using System.Runtime.InteropServices.Marshalling;

class Program
{
    static void Main(string[] args)
    {
        Pokemon pokedex;
        Console.WriteLine("Making a New Pokedex Entry!");
        Console.WriteLine("Let's get some information out of the way:");
        Console.Write("What is the name of the Pokemon? ");
        string name = Console.ReadLine();
        Console.Write("What kind of pokemon is it (a cat, bird, dog, distortion)? ");
        string pokemon = Console.ReadLine();
        Console.Write("What Egg Group is it part of (water 1, field, unknown)? ");
        string eggGroup = Console.ReadLine();

        Console.WriteLine("\nNow, how is the pokemon identified?");
        Console.WriteLine("1.Legendary");
        Console.WriteLine("2.Starter");
        Console.WriteLine("3.Mythical");
        Console.WriteLine("Other.Regular");
        Console.Write("Answer with the number: ");
        string answer = Console.ReadLine();
        int kind = int.Parse(answer);

        if (kind == 1)
        {
            pokedex = new Legendary(name, pokemon, eggGroup);
        }
        else if (kind==2)
        {
            pokedex = new Starter(name,pokemon, eggGroup);
            starter.SetProfessor();
        }
        else if(kind == 3)
        {
            Console.Write("On what date/s is/was this pokemon available (MM/DD/YYYY): ");
            string eventDate = Console.ReadLine();
            pokedex = new Mythical(name,pokemon,eggGroup,eventDate);
        }
        else
        {
            pokedex = new Pokemon(name,pokemon,eggGroup);
        }
        pokedex.SetTypings();
        pokedex.MakeAbility();
        pokedex.SetLocations();
        pokedex.SetStats();

        string filename;
        string filename2;
        string filename3;
        string filename4;

        Console.WriteLine("Now we'll save the info on 4 new files");
        Console.Write("What is the first file? ");
        filename = Console.ReadLine();
        Console.Write("Second File? ");
        filename2 = Console.ReadLine();
        Console.Write("Third File? ");
        filename3 = Console.ReadLine();
        Console.Write("Fourth File? ");
        filename4 = Console.ReadLine();

        StreamWriter outputFile = new StreamWriter(filename);
        StreamWriter outputFile2 = new StreamWriter(filename2);
        StreamWriter outputFile3 = new StreamWriter(filename3);
        StreamWriter outputFile4 = new StreamWriter(filename4);

        pokedex.SaveEntries(outputFile,outputFile2,outputFile3,outputFile4);
    }
}