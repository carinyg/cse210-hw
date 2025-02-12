using System;

class Program
{
    static void Main(string[] args)
    {
        // Shape shape = new Square("blue", 14);
        // Console.WriteLine($"Area of the square is {shape.GetArea()}");
        // Console.WriteLine($"Color of the square is {shape.GetColor()}");

        // shape = new Rectangle("red", 10, 20);
        // Console.WriteLine($"Area of the rectangle is {shape.GetArea()}");
        // Console.WriteLine($"Color of the rectangle is {shape.GetColor()}");

        // shape = new Circle("yellow", 7);
        // Console.WriteLine($"Area of the circle is {shape.GetArea()}");
        // Console.WriteLine($"Color of the circle is {shape.GetColor()}");

        List<Shape> shapes = new List<Shape>();
        shapes.Add(new Square("blue", 14));
        shapes.Add(new Rectangle("red", 10, 20));
        shapes.Add(new Circle("yellow", 7));

        foreach (Shape shape in shapes)
        {
            Console.WriteLine($"Area of the shape is {shape.GetArea()}");
            Console.WriteLine($"Color of the shape is {shape.GetColor()}");
        }
    }
}