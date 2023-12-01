using System;
using System.Diagnostics;

public class ChecklistGoal : Goal
{
    // Attributes
    private string _goalType = "Checklist Goal:";
    private int _numTimes;
    private int _bonusPoints;
    private bool _status;
    private int _count;

    // Constructors
    public ChecklistGoal(string goalType, string name, string description, int points, int numTimes, int bonusPoints) : base(goalType, name, description, points)
    {
        _status = false;
        _numTimes = numTimes;
        _bonusPoints = bonusPoints;
        _count = 0;
    }
    public ChecklistGoal(string goalType, string name, string description, int points, bool status, int numTimes, int bonusPoints, int count) : base(goalType, name, description, points)
    {
        _status = status;
        _numTimes = numTimes;
        _bonusPoints = bonusPoints;
        _count = count;
    }
    public int GetTimes()
    {
        return _numTimes;
    }
    public void SetTimes()
    {
        _count = _count + 1;
    }
    public int GetCount()
    {
        return _count;
    }
    public void SetCount()
    {

    }
    public int GetBonusPoints()
    {
        return _bonusPoints;
    }
    public Boolean Finished()
    {
        return _status;
    }
    //Methods

    public override void ListGoal(int i)
    {
        if (Finished() == false)
        {
            Console.WriteLine($"{i}. [ ] {GetName()} ({GetDescription()})  --  Currently Completed: {GetCount()}/{GetTimes()}");
        }
        else if (Finished() == true)
        {
            Console.WriteLine($"{i}. [X] {GetName()} ({GetDescription()})  --  Completed: {GetCount()}/{GetTimes()}");
        }
    }
    public override string SaveGoal()
    {
        return ($"{_goalType}; {GetName()}; {GetDescription()}; {GetPoints()}; {_status}; {GetTimes()}; {GetBonusPoints()}; {GetCount()}");
    }
    public override string LoadGoal()
    {
        return ($"Simple Goal:; {GetName()}; {GetDescription()}; {GetPoints()}; {_status}; {GetTimes()}; {GetBonusPoints()}; {GetCount()}");
    }
    public override void RecordGoalEvent(List<Goal> goals)
    {
        SetTimes();
        int points = GetPoints();

        if (_count == _numTimes)
        {
            _status = true;
            points = points + _bonusPoints;

            Console.WriteLine($"Congratulations! You have earned {points} points!");
        }
        else
        {
            Console.WriteLine($"Congratulations! You have earned {GetPoints()} points!");
        }
    }
}