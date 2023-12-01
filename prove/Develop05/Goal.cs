using System;

public abstract class Goal
{
    // Attributes 
    private string _goalType;
    private string _name;
    private string _description;
    private int _points;

    //Constructors
    public Goal(string goalType, string name, string description, int points)
    {
        _goalType = goalType;
        _name = name;
        _description = description;
        _points = points;
    }

    public string GoalType()
    {
        return _goalType;
    }
    public string GetName()
    {
        return _name;
    }
    public string GetDescription()
    {
        return _description;
    }
    public int GetPoints()
    {
        return _points;
    }

    //Methods
    public abstract void ListGoal(int i);
    public abstract string SaveGoal();
    public abstract string LoadGoal();
    public abstract void RecordGoalEvent(List<Goal> goals); 
    }