using System;

class Program
{
    static void Main(string[] args)
    {
        Reference reference = new Reference("Proverbs", 3, "5", "6");
        Scripture scripture = new Scripture("Trust in the Lord with all thine heart; and lean not unto thine own understanding. In all thy ways acknowledge him, and he shall direct thy paths.");
        Word word = new Word();
        string wantsToQuit = "";

        Console.WriteLine($"{reference.GetReference()} {scripture.GetText()}\n");

        Console.Write("Press enter to continue or type 'quit' to finish: ");
        wantsToQuit = Console.ReadLine();

        while (!(wantsToQuit.ToLower().Equals("quit")))
        {
            scripture.HideWords(word);
            Console.Clear();

            Console.WriteLine($"{reference.GetReference()} {scripture.GetText()}\n");

            Console.Write("Press enter to continue or type 'quit' to finish: ");
            wantsToQuit = Console.ReadLine();
        }
    }
}