using System;

public class EternalGoal : Goal
{
     // Attributes
     private string _goalType = "EternalGoal:";
     private bool _status;

     // Constructors
    public EternalGoal(string goalType, string name, string description, int points) : base(goalType, name, description, points)
    {
        _status = false;
    }
    public EternalGoal(string goalType, string name, string description, int points, bool status) : base(goalType, name, description, points)
    {
        _status = status;
    }
    //Methods
    public override void ListGoal(int i)
    {
        Console.WriteLine($"{i}. [ ] {GetName()} ({GetDescription()})");
    }
    public override string SaveGoal()
    {
        return ($"{_goalType}; {GetName()}; {GetDescription()}; {GetPoints()}; {_status}");
    }
    public override string LoadGoal()
    {
        return ($"{_goalType}; {GetName()}; {GetDescription()}; {GetPoints()}; {_status}");
    }
    public override void RecordGoalEvent(List<Goal> goals)
    {
        Console.WriteLine($"Congratulations! You have earned {GetPoints()} points!");
    }

}