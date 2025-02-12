using System;

class Program
{
    static void Main(string[] args)
    {
        Shape shape = new Square("blue", 14);
        Console.WriteLine($"Area of the square is {shape.GetArea()}");
        Console.WriteLine($"Color of the square is {shape.GetColor()}");

        shape = new Rectangle("red", 10, 20);
        Console.WriteLine($"Area of the rectangle is {shape.GetArea()}");
        Console.WriteLine($"Color of the rectangle is {shape.GetColor()}");
        
    }
}