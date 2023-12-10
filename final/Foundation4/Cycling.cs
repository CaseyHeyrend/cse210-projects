using System;

public class Cycling : Exercise //Stationary Bicycles
{
    //Attributes 
    private double _speed;

    //Constructors
    public Cycling(string date, int minutes, double speed) : base(date, minutes)
    {
        _name = "Cycling";
        _speed = speed;
    }

    //Methods
    public override double CalculateDistance()//GetDistance
    {
        double distance = _speed * _minutes / 60;
        return distance;

    }
     public override double CalculateSpeed()//GetSpeed
    {
        return _speed;
    }
    public override double CalculatePace()//GetPace
    {
        double pace = 60 / _speed;
        return pace;
    }
}