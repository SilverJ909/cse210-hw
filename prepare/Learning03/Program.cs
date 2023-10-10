using System;

class Program
{
    static void Main(string[] args)
    {
        List<Fraction> fractions = new List<Fraction>();
        Fraction firstFraction = new Fraction();
        Fraction secondFraction = new Fraction(5);
        Fraction thirdFraction = new Fraction(1, 3);

        firstFraction.SetTop(3);
        firstFraction.SetBottom(5);

        fractions.Add(firstFraction);
        fractions.Add(secondFraction);
        fractions.Add(thirdFraction);

        foreach (Fraction i in fractions)
        {
            Console.WriteLine($"Numerator: {i.GetTop()}");
            Console.WriteLine($"Denominator: {i.GetBottom()}");
            Console.WriteLine($"Fraction: {i.GetFractionString()}");
            Console.WriteLine($"Decimal: {i.GetDecimalValue()}\n");
        }
    }
}