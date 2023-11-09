using System;

class Program
{
    static void Main(string[] args)
    {
        List<Shape> shapes = new List<Shape>();

        Square square = new Square("Blue", 5);
        Rectangle rectangle = new Rectangle(2.5, 12, "Pink");
        Circle circle = new Circle(6, "Green");

        shapes.Add(square);
        shapes.Add(rectangle);
        shapes.Add(circle);

        foreach(Shape i in shapes)
        {
            Console.WriteLine($"Color: {i.GetColor()}");
            Console.WriteLine($"Area: {i.GetArea()}");
        }
    }
}