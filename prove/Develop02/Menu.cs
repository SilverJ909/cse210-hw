using System;

class Menu
{
    public List<string> _list = new List<string>();

    public void Display()
    {
        Console.WriteLine("1. Write\n2. Display\n3. Load\n4. Save\n5. Quit");

        Console.Write("What would you like to do?");
    }
}