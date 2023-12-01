using System;
using System.IO;

public class GoalManger
{
    // Attributes
    private List<Goal> _goals = new List<Goal>();
    private int _score;

    // Constructors
    public GoalManger()
    {
        _score = 0;
    }
    public void AddGoal(Goal goal)
    {
        _goals.Add(goal);
    }
    public int GetScore()
    {
        return _score;
    }
    public void AddPoints(int points)
    {
        _score += points;
    }
    public void AddBonus(int bonusPoints)
    {
        _score += bonusPoints;
    }
    public void SetScore(int score)
    {
        _score = score;
    }
    public List<Goal> GetGoalsList()
    {
        return _goals;
    }
    // Methods
    public void ListGoals()
    {
        if (_goals.Count() > 0)
        {
            Console.WriteLine("\nYour Goals are:");

            int index = 1;
            foreach (Goal goal in _goals)
            {
                goal.ListGoal(index);
                index = index + 1;
                
            }
        }
        else 
        {
            Console.WriteLine("\nYou currently have no goals!");
        }
    }
    public void RecordGoalEvent()
    {
        ListGoals();

        Console.Write("\nWhich goal did you accomplished?  ");
        int select = int.Parse(Console.ReadLine())-1;

        int goalPoints = GetGoalsList()[select].GetPoints();
        AddPoints(goalPoints);

        GetGoalsList()[select].RecordGoalEvent(_goals);

        Console.WriteLine($"\n--- You have {GetScore()} points! ---\n");

    }
    public void SaveGoals()
    {
        Console.Write("\nWhat is the file name?  ");
        string userInput = Console.ReadLine();
        string userFileName = userInput + ".txt";

        using (StreamWriter outputFile = new StreamWriter(userFileName))
        {
            // Should Save the score or the Total points
            outputFile.WriteLine(GetScore());

            foreach (Goal goal in _goals)
            {
                outputFile.WriteLine(goal.SaveGoal());
            }
        }
    }
    public void LoadGoals()
    {
        Console.Write("\nWhat is the file name?  ");
        string userInput = Console.ReadLine();
        string userFileName = userInput + ".txt";
        if (File.Exists(userFileName))
        {
            string[] readText = File.ReadAllLines(userFileName);
            int totalPoints = int.Parse(readText[0]);
            SetScore(totalPoints);

            readText = readText.Skip(1).ToArray();

            foreach (string line in readText)
            {
                string[] entries = line.Split("; ");

                string goalType = entries[0];
                string name = entries[1];
                string description = entries[2];
                int points = int.Parse(entries[3]);
                bool status = Convert.ToBoolean(entries[4]);
                if (entries[0] == "SimpleGoal")
                {
                    SimpleGoal simGoal = new SimpleGoal(goalType, name, description, points, status);
                    AddGoal(simGoal);
                }
                if (entries[0] == "EternalGoal")
                {
                    EternalGoal eterGoal = new EternalGoal(goalType, name, description, points, status);
                    AddGoal(eterGoal);
                }
                if (entries[0] == "ChecklistGoal")
                {
                    int numberTimes = int.Parse(entries[5]);
                    int bonusPoints = int.Parse(entries[6]);
                    int counter = int.Parse(entries[7]);
                    ChecklistGoal chelisGoal = new ChecklistGoal(goalType, name, description, points, status, numberTimes, bonusPoints, counter);
                    AddGoal(chelisGoal);
                }
            }


        }

    }
   
}