using System;

class Program
{
    static void Main(string[] args)
    {
        int i = 0;
        int points = 0;
        List<Goal> goals = new List<Goal>();
        while (i != 6)
        {
            int j = 1;
            Console.WriteLine($"\nYou have {points} points.\n");
            Console.WriteLine("Menu Otions:");
            Console.WriteLine("\t1. Create New Goal");
            Console.WriteLine("\t2. List Goals");
            Console.WriteLine("\t3. Save Goals");
            Console.WriteLine("\t4. Load Goals");
            Console.WriteLine("\t5. Record Events");
            Console.WriteLine("\t6. Quit");
            Console.Write("Select a choice from the menu: ");
            string choice = Console.ReadLine();
            i = int.Parse(choice);
            if (i == 1)
            {
                int k = 0;
                Console.WriteLine("The types of Goals are: ");
                Console.WriteLine("\t1. Simple Goal");
                Console.WriteLine("\t2. Eternal Goal");
                Console.WriteLine("\t3. Checklist Goal");
                Console.Write("Which type of goal would you like to create?  ");
                choice = Console.ReadLine();
                k = int.Parse(choice);
                if(k == 1)
                {
                    SimpleGoal simpleGoal = new SimpleGoal();
                    simpleGoal.SetInformation();
                    goals.Add(simpleGoal);
                }
                else if(k == 2)
                {
                    EternalGoal eternalGoal = new EternalGoal();
                    eternalGoal.SetInformation();
                    goals.Add(eternalGoal);
                }
                else if (k == 3)
                {
                    ChecklistGoal checklistGoal = new ChecklistGoal();
                    checklistGoal.SetInformation();
                    goals.Add(checklistGoal);
                }
            }
            else if(i == 2)
            {
                foreach (Goal goal in goals)
                {
                    if(goal.GetComplete() == true)
                    {
                        Console.WriteLine($"{j}. [X] {goal.GetName()} ({goal.GetDescription()} {goal.AddCompletedHours()})");
                    }
                    else
                    {
                        Console.WriteLine($"{j}. [] {goal.GetName()} ({goal.GetDescription()}) {goal.AddCompletedHours()}");
                    }
                    j++;
                }
            }
            else if (i == 3)
            {
                string filename;
                Console.Write("What is the filename for the goal file? ");
                filename = Console.ReadLine();
                using (StreamWriter outputfile = new StreamWriter(filename))
                {
                    outputfile.WriteLine(points);
                    foreach (Goal goal in goals)
                    {
                        goal.SaveInfo(outputfile);
                    }
                }
            }
            else if (i == 4)
            {
                string filename;
                Console.Write("What is the filename for the goal file? ");
                filename = Console.ReadLine();
                string[] lines = System.IO.File.ReadAllLines(filename);
                points = int.Parse(lines[0]);
                foreach(string line in lines)
                {
                    string[] parts = line.Split(",");
                    string[] typeNameSplit = parts[0].Split(":");

                    string name = typeNameSplit[1];
                    string description = parts[1];
                    int point = int.Parse(parts[2]);
                    if (typeNameSplit[0].Equals("SimpleGoal"))
                    {
                        SimpleGoal simpleGoal = new SimpleGoal(name,description,point);
                        goals.Add(simpleGoal);
                    }
                    else if(typeNameSplit[0].Equals("EternalGoal"))
                    {
                        EternalGoal eternalGoal = new EternalGoal(name,description,point);
                        goals.Add(eternalGoal);
                    }
                    else if(typeNameSplit[0].Equals("ChecklistGoal"))
                    {
                        ChecklistGoal checklistGoal =  new ChecklistGoal(name, description, point);
                        goals.Add(checklistGoal);
                    }
                }
            }
            else if (i == 5)
            {
                Console.WriteLine("The goals are:");
                foreach (Goal goal in goals)
                {
                    Console.WriteLine($"{j}. {goal.GetName()}");
                    j++;
                }
                Console.Write("Which goal id you accomplish? ");
                string c = Console.ReadLine();
                j = int.Parse(c);
                j--;
                points += goals[j].AddPoints();
                goals[j].CompleteGoal();
            }
            else if (i == 6)
            {
                Console.WriteLine("Goodbye for now!");
            }
        }
    }
}