using System;

public class Circle : Shape
{
    private double _radius = 4;

    public override double GetArea()
    {
        return _radius * _radius * Math.PI;
    }
}