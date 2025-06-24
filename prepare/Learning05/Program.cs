using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        // Create shapes
        Shape square = new Square("Red", 4);
        Shape rectangle = new Rectangle("Blue", 5, 6);
        Shape circle = new Circle("Green", 3);

        // Store in a list
        List<Shape> shapes = new List<Shape> { square, rectangle, circle };

        // Display color and area
        foreach (Shape shape in shapes)
        {
            Console.WriteLine($"Color: {shape.GetColor()}, Area: {shape.GetArea()}");
        }
    }
}

}