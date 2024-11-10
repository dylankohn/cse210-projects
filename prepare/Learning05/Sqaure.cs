using System;

public class Square : Shape
{
    private double _side = 4;

    public override double GetArea()
    {
        return _side * _side;
    }
}