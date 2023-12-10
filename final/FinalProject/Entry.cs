using System;

public class Entry
{
    private int _entryNum;
    private string _description;

    public Entry()
    {
        _entryNum = 0;
        _description = "";
    }

    public void SetEntryNumber(int entryNum)
    {
        _entryNum = entryNum;
    }
    public void SetDescription(string description)
    {
        _description = description;
    }
    public int GetEntryNumber()
    {
        return _entryNum;
    }
    public string GetDescription()
    {
        return _description;
    }

    public string DiplayEntry()
    {
        return $"{_entryNum}: {_description}";
    }
}