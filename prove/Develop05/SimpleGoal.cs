using System;

public class SimpleGoal : Goal //Inheritance
{
    // Attributes
    private string _goalType ="Simple Goal:";
    private bool _status;
    

    public SimpleGoal(string goalType, string name, string description, int points) : base(goalType, name, description, points)
    {
        _status = status;
    }
    public SimpleGoal(string goalType, string name, string description, int points, bool status) : base(goalType, name, description, points)
    {
        
    }

   
}