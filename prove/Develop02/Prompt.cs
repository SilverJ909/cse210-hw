using System;

class Prompt
{
    public List<string> _list = new List<string> {"What did I eat today?", "What did I see today?", "What did i buy today?", "If I had one thing I could do over today?"};

    public void Display()
    {
        Random randomNum = new Random();
        int num = randomNum.Next(1, _list.Count)-1;

        Console.Write($"{_list[num]}"); 
    }
}