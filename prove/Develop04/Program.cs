using System;

class Program
{
    static void Main(string[] args)
    {
        int menuChoice = 0;
        DateTime time = DateTime.Now;
        DateTime futureTime;
        int timesBreathing = 0;
        int timesReflecting = 0;
        int timesListing = 0;

        while (menuChoice != 4)
        {
            Console.WriteLine("Menu Options:");
            Console.WriteLine(" 1. Start breathing activity");
            Console.WriteLine(" 2. Start reflecting activity");
            Console.WriteLine(" 3. Start listing activity");
            Console.WriteLine(" 4. Quit");
            Console.Write("Select a choice from the menu: ");
            string answer = Console.ReadLine();
            menuChoice = int.Parse(answer);
            Console.Clear();
            if (menuChoice == 1)
            {
                BreathingActivity breathingActivity = new BreathingActivity();

                breathingActivity.DisplayStartMessage();
                Console.Clear();
                breathingActivity.GetReady();
                time = DateTime.Now;
                futureTime = time.AddSeconds(breathingActivity.GetDuration());
                while (DateTime.Now < futureTime)
                {
                    breathingActivity.DisplayBreathIn();
                    breathingActivity.PauseWithTimer(5);
                    Console.WriteLine();
                    breathingActivity.DisplayBreathOut();
                    breathingActivity.PauseWithTimer(5);
                    Console.WriteLine();
                }
                breathingActivity.DisplayEndMessage();
                timesBreathing += 1;
            }
            else if (menuChoice == 2)
            {
                ReflectionActivity reflectionActivity = new ReflectionActivity();
                
                reflectionActivity.DisplayStartMessage();
                Console.Clear();
                reflectionActivity.GetReady();
                reflectionActivity.GetRandomPrompt();
                time = DateTime.Now;
                futureTime = time.AddSeconds(reflectionActivity.GetDuration());
                while (DateTime.Now < futureTime)
                {
                    reflectionActivity.GetQuestions();
                }
                reflectionActivity.DisplayEndMessage();
                timesReflecting += 1;
            }
            else if (menuChoice == 3)
            {
                ListingActivity listingActivity = new ListingActivity();
                
                listingActivity.DisplayStartMessage();
                Console.Clear();
                listingActivity.GetReady();
                listingActivity.EnterRandomPrompt();
                time = DateTime.Now;
                futureTime = time.AddSeconds(listingActivity.GetDuration());
                while(DateTime.Now < futureTime)
                {
                    listingActivity.RecieveAnswers();
                }
                Console.WriteLine($"You listed {listingActivity.ReturnNumberItemsEntered()} items");
                Console.WriteLine();
                listingActivity.DisplayEndMessage();
                timesListing += 1;
            }
            
            Console.Clear();

            if (menuChoice == 4)
            {
                Console.WriteLine("Goodbye");
                Console.WriteLine($"Breathing Activities done: {timesBreathing}");
                Console.WriteLine($"Reflecting Activities done: {timesReflecting}");
                Console.WriteLine($"Listing Activities done: {timesListing}");
            }
        }
    }
}