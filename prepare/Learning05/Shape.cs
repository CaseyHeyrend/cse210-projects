using System;

public abstract class Shape
{
    //Attributes
    private string _color;

    //Constructors
    public Shape(string color)
    {
        _color = color;
    }
    public string GetColor()
    {
        return _color;
    }

    public void SetColor(string color)
    {
        _color = color;
    }
    //Methods
    public abstract double GetArea();

    public abstract string GetShapeType();
}