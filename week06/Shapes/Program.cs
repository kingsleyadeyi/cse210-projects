using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        List<Shape> shapes = new List<Shape>();

        shapes.Add(new Square("Red", 5));
        shapes.Add(new Square("Yellow", 7));

        shapes.Add(new Rectangle("Blue", 10, 4));
        shapes.Add(new Rectangle("Orange", 6, 3));

        shapes.Add(new Circle("Green", 3));
        shapes.Add(new Circle("Purple", 5));

        foreach (Shape shape in shapes)
        {
            Console.WriteLine($"Color: {shape.GetColor()}");
            Console.WriteLine($"Area: {shape.GetArea()}");
            Console.WriteLine();
        }
    }
}