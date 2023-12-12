using System;

public class Swimming :Exercise
{
     //Attributes 
     private double _laps;//Number of Laps

    //Constructors

    public Swimming(string date, int minutes, int laps) : base(date, minutes)
    {
        _name = "Swimming";
        _laps = laps;
    }
        
    //Methods
    public override double CalculateDistance()//GetDistance
    {
        double distance = Math.Round(_laps * 50 / 1000 * 0.62);
        return distance;
    }
    public override double CalculateSpeed()//GetSpeed
    {
        double speed = CalculateDistance() / _minutes * 60;
        return speed;
    }
    public override double CalculatePace()//GetPace
    {
        double pace = _minutes / CalculateDistance();
        return pace;
    }
}