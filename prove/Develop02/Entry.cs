using System;
using System.IO;

class Entry
{
    string _entry = "";
    public Prompt _prompt = new Prompt();

    public void Prompt()
    {
        _prompt.Display();
        _entry = Console.ReadLine();
    }

    public void SaveEntry()
    {
    }
}