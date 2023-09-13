using System;
using Microsoft.VisualBasic;

class Program
{
    static void Main(string[] args)
    {
        //Instantiate a string variable for the letter grade and int value for the last digit
        string letter = null;
        int lastDigit = 0;

        //Get the Number Grade
        Console.Write("What number grade did you get in this course?: ");
        string grade = Console.ReadLine();
        int gradeNumber = int.Parse(grade); //convert to in value

        //Determine the letter grade
        if (gradeNumber >= 90)
        {
            letter = "A";
            lastDigit = gradeNumber-90;
        }
        else if (gradeNumber >= 80)
        {
            letter = "B";
            lastDigit = gradeNumber-80;
        } 
        else if (gradeNumber >= 70)
        {
            letter = "C";
            lastDigit = gradeNumber - 70;
        }
        else if (gradeNumber >= 60)
        {
            letter = "D";
            lastDigit = gradeNumber - 60;
        }
        else
        {
            letter = "F";
        }


        //Add "+" or "-" if neccessary
        if (lastDigit >= 7 && (letter != "F" && letter != "A"))
        {
            letter = letter+"+";
        }
        else if (lastDigit < 3 && letter != "F")
        {
            letter = letter+"-";
        }

        //Determine if they pass and display the letter and pass/fail message 
        Console.WriteLine();
        Console.WriteLine($"Letter Grade:{letter}");

        if (gradeNumber >= 70)
        {
            Console.WriteLine("Congratulations! You passed the class.");
        }
        else 
        {
            Console.WriteLine("I'm sorry, that isn't a passing grade. Don't give up. Try again.");
        }
    }
}