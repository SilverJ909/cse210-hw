using System;

public class ListingActivity : Activity
{
    private List<string> _prompt = new List<string>();
    private int _items = 0;

    public ListingActivity() : base("Listing Activity","This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.")
    {
        _prompt.Add("Who are people that you appreciate?");
        _prompt.Add("What are personal strengths of yours?");
        _prompt.Add("Who are people that helped this week?");
        _prompt.Add("When have you felt the Holy Ghost this month?");
        _prompt.Add("Who are some of your personal heroes?");
    }

    public void EnterRandomPrompt()
    {
        Random randGen = new Random();
        int randNum = randGen.Next(0, _prompt.Count());

        Console.WriteLine("List as many responses you can to the following prompt:");
        Console.WriteLine($"--- {_prompt[randNum]} ---");
        Console.Write("You may begin in: ");
        PauseWithTimer(5);
        Console.WriteLine();
    }
    public void RecieveAnswers()
    {
        Console.Write("");
        string answer = Console.ReadLine();

        _items += 1;
    }
    public int ReturnNumberItemsEntered()
    {
        return _items;
    }
}