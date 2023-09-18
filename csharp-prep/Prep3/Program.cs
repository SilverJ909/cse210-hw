using System;
using System.Formats.Asn1;

class Program
{
    static void Main(string[] args)
    {
        int guess = 0;
        string g = null;
        int guesses = 0;
        string toPlay = "yes";

        while (toPlay.ToLower() == "yes")
        {
            Random randomGenerator = new Random();
            int magicNum = randomGenerator.Next(1,100);
            guess = 0;
            guesses = 0;
            Console.WriteLine("Guess the magic number");


            while (guess != magicNum)
            {
                Console.Write("What is your guess? ");
                g = Console.ReadLine();
                guess = int.Parse(g);

                if (guess == magicNum)
                {
                    Console.WriteLine("You guessed it!");
                }
                else if (guess < magicNum)
                {
                    Console.WriteLine("Higher");
                }
                else
                {
                    Console.WriteLine("Lower");
                }
                guesses++;
            }
            Console.WriteLine($"It took you {guesses} guesses.");

            Console.Write("Play again? ");
            toPlay = Console.ReadLine();
        }
    }
}