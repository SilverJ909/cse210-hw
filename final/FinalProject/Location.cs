using System;

public class Location
{
    public List<string> _habitats;
    public List<string> _regions;
    public List<string> _habitatRegions;

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

    
}