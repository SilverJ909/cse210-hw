using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        int addedNumber = 1;
        List<int> numbers = new List<int>();
        int sum = 0;
        double average = 0;
        int largestNumber; 
        int smallestPosNum;


        Console.WriteLine("Enter a list of numbers, type 0 when finished.");

        while (addedNumber != 0)
        {
            Console.Write("Enter number: ");
            string adding = Console.ReadLine();
            addedNumber = int.Parse(adding);
            if(addedNumber != 0)
            {
                numbers.Add(addedNumber);
            }
        }

        largestNumber = numbers[0];
        smallestPosNum = numbers[0];

        foreach (int i in numbers)
        {
            sum += i;

            if (i > largestNumber)
            {
                largestNumber = i;
            }
            if (i > 0 && i < smallestPosNum)
            {
                smallestPosNum = i;
            }
        } 
        double doubledCount = numbers.Count;
        average = sum/doubledCount;

        Console.WriteLine($"The sum is: {sum}");
        Console.WriteLine($"The average is: {average}");
        Console.WriteLine($"The largest number is: {largestNumber}");
        Console.WriteLine($"The smallest positive number is: {smallestPosNum}");

    }
}