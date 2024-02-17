using System;

public class Shape
{
    private string _color;

    public Shape(string colour)
    {
        SetColor(colour);
    }

    public string GetColor()
    {
        return _color;
    }

    public void SetColor(string color)
    {
        _color = color;
    }

    public virtual double GetArea()
    {
        double area = 10;
        return area;
    }

}
   

