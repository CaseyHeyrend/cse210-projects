using System;

public class Goal
{
    protected string _sName;//Short Name
    protected string _description;
    protected int _goalPoints;
    protected bool _status;
    
    public Goal()
    {
        _sName = "Test Name";
        _description = "Test Description";
        _goalPoints = 50;
        _status = false;
    }

    public Goal(string sName, string description, int goalPoints)
    {
        _sName = sName;
        _description = description;
        _goalPoints = goalPoints;
    }
    


}