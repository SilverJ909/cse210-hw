using System;
using System.ComponentModel.DataAnnotations;
using System.Configuration.Assemblies;

public class Location
{
    public List<string> _habitats;
    private List<string> _regions;
    private List<string> _habitatRegions;

    public Location()
    {
        _habitats = new List<string>();
        _regions = new List<string>();
        _regions.Add("Kanto");
        _regions.Add("Johto");
        _regions.Add("Hoenn");
        _regions.Add("Sinnoh");
        _regions.Add("Unova");
        _regions.Add("Kalos");
        _regions.Add("Alola");
        _regions.Add("Galar");
        _regions.Add("Paldea");
        _habitatRegions = new List<string>();
    }

    public int GetCount()
    {
        return _habitats.Count();
    }

    public void AddALocation()
    {
        int i = 1;
        Console.Write("Where can you find this Pokemon?: ");
        string habitat = Console.ReadLine();
        _habitats.Add(habitat);

        Console.WriteLine("What region is it in?");
        foreach(string region in _regions)
        {
            Console.WriteLine($"{i}. {region}");
            i++;
        }
        Console.WriteLine($"{i}. New Region");
        Console.Write("Answer with number: ");
        string num = Console.ReadLine();
        int regNum = int.Parse(num);
        LocationToRegion(regNum);
    }

    public void LocationToRegion(int choice)
    {
        if(choice == (_regions.Count()+1))
        {
            MakeNewRegion();
        }
        _habitatRegions.Add(_regions[choice-1]);
    }

    public void MakeNewRegion()
    {
        Console.Write("What is the new Region's name? ");
        string region = Console.ReadLine();
        
        _regions.Add(region);
    }

    public string DisplayLocation(int index)
    {
        return $"{_habitats[index]}({_habitatRegions[index]})";
    }
}