using System;


class Program
{
    static void Main(string[] args)
    {
        DisplayWelcome();
        string userName = PromptUserName();
        int userNum = PromptUserNumber();
        int squaredNum = SquareNumber(userNum);
        DisplayResult(userName, squaredNum);
    }

    static void DisplayWelcome()
    {
        Console.WriteLine("Welcome to the Program");   
    }

    static string PromptUserName()
    {
        Console.Write("Pleae enter your name: ");
        return Console.ReadLine();
    }

    static int PromptUserNumber()
    {
        Console.Write("Please enter you favorite number: ");
        string number = Console.ReadLine();
        int num = int.Parse(number);
        return num;
    }

    static int SquareNumber(int num)
    {
        int squaredNum = num*num;
        return squaredNum;
    }

    static void DisplayResult(string name, int squaredNum)
    {
        Console.WriteLine($"{name}, the square of your number is {squaredNum}");
    }
}