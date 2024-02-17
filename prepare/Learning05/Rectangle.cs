using System;

public class Rectangle : Shape
{
    private double _length;
    private double _breadth;

    public Rectangle(string color, double length, double breadth) : base(color)
    {
        _length = length;
        _breadth = breadth;
    }

    public override double GetArea()
    {
        return _length * _breadth;
    }
}