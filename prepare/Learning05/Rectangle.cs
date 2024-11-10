using System;

public class Rectangle : Shape
{
    private double _length = 4;
    private double _width = 2;

    public override double GetArea()
    {
        return _length * _width;
    }
}