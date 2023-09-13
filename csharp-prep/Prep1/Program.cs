using System;

class Program
{
    static void Main(string[] args)
    {
        //Get First Name
        Console.Write("What is your first name? ");
        string first_name = Console.ReadLine();

        //Get Last Name
        Console.Write("What is your last name? ");
        string last_name = Console.ReadLine();

        //Display the first and last name as "Your name is last_name, first_name last_name
        Console.WriteLine();
        Console.WriteLine($"Your name is {last_name}, {first_name} {last_name}.");
    }
}