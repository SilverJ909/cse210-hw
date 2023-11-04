using System;
using System.Runtime.CompilerServices;

public class ReflectionActivity : Activity
{
    private List<string> _prompt = new List<string>();
    private List<string> _questions = new List<string>();


    public ReflectionActivity() : base("Reflection Activity","This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.")
    {
        _prompt.Add("Think of a time when you stood up for someone else.");
        _prompt.Add("Think of a time when you did something really difficult.");
        _prompt.Add("Think of a time when you helped someone in need.");
        _prompt.Add("Think of a time when you did something truly selfless.");

        _questions.Add("Why was this experience meaningful to you?");
        _questions.Add("Have you ever done anything like this before?");
        _questions.Add("How did you get started?");
        _questions.Add("How did you feel when it was complete?");
        _questions.Add("What made this time different than other times when you were not as successful?");
        _questions.Add("What is your favorite thing about this experience?");
        _questions.Add("What could you learn from this experience that applies to other situations?");
        _questions.Add("What did you learn about yourself through this experience?");
        _questions.Add("How can you keep this experience in mind in the future?");
    }

    public void AddPrompts(string prompt)
    {
        _prompt.Add(prompt);
    }

    public void GetRandomPrompt()
    {
        Random prompts = new Random();
        int randPrompt = prompts.Next(0,_prompt.Count());

        Console.WriteLine("Consider the following prompt:");
        Console.WriteLine($"--- {_prompt[randPrompt]} ---");
        
        Console.WriteLine("When you have something in mind, press enter to continue.");
        string enter = Console.ReadLine();

        Console.WriteLine("Now ponder on each of the following questions as they related to this experience.");
        Console.Write("You may begin in: ");
        PauseWithTimer(5);
    }

    public void GetQuestions()
    {
        Random randQuestion = new Random();
        int questions = randQuestion.Next(0,_questions.Count());

        Console.Write(_questions[questions]);
        PauseWithSpinner();
        PauseWithSpinner();
        Console.WriteLine();
    }
}