using System;

public class SimpleGoal : Goal //Inheritance
{
    public SimpleGoal()
    {
        _name = "Name of Simple Goal";
        _description = "Description of Simple Goal";
        _goalPoints = 50;
        _status = false;
    }

    public SimpleGoal(string name, string description, int goalPoints, bool status)
    {
        _name = name;
        _description = description;
        _goalPoints = goalPoints;
        _status = status;
    }

   
}