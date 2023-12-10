using System;

public class Running : Exercise
{

    //Attributes 
    private double _distance;

    //Constructors

    public Running(string date, int minutes, double distance) : base(date, minutes)
    {
        _name = "Running";
        _distance = distance;
    }

    //Methods

    public override double CalculateDistance()//GetDistance
    {
        return _distance;
    }
    public override double CalculateSpeed()//GetSpeed
    {
        double speed = (_distance / _minutes) * 60;
        return speed;
    }
    public override double CalculatePace()//GetPace
    {
        double pace = _minutes / _distance;
        return pace;
    }
}