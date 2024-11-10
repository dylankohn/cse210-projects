using System;
using System.Globalization;
using System.Security.Cryptography.X509Certificates;

class Program
{
    static void Main(string[] args)
    {
        List<Shape> shapes = new List<Shape>();
    
        shapes.Add(new Square());
        shapes.Add(new Rectangle());
        shapes.Add(new Circle());

        foreach (var shape in shapes)
        {
            Console.WriteLine($"The area of the shape is {shape.GetArea()} and the color is {shape.GetColor()}");
        }
    }
}