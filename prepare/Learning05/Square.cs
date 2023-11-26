using System;

public class Square : Shape
{
    //Attributes
    private double _side = 0;
    private string _type = "Square";

    //Constructors

    public Square(string color, double side) : base(color)
    {
        _side = side;
    }
    public override string GetShapeType()
    {
        return _type;
    }
    //Methods
    public override double GetArea()
    {
        return _side * _side;
    }

}