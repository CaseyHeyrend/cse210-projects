using System;
using System.IO;
using System.Globalization;

class Program
{
    static void Main(string[] args)
    {
        //Console.WriteLine("Hello Develop05 World!");
        //Convert text to title case
        TextInfo textInfo = new CultureInfo("en-US", false).TextInfo;

        GoalManger goals = new GoalManger();

        Console.Clear();
        Console.Write("\n--- Welcome to the Eternal Quest ---");
        

        Console.Write($"\n--- You currently have {goals.GetScore()} points ---\n");
        // Calling Main Menu
        ChoiceMenu choice = new ChoiceMenu();
        // Calling The Goals Menu
        GoalMenu goalChoice = new GoalMenu();

        int action = 0;
        while (action != 6)
        // Switch Case for the Main menu 
        {
            action = choice.UserChoice();
            switch (action)
            {
                case 1:
                    // Create New Goal
                    Console.Clear();
                    int goalInput = 0;
                    while (goalInput != 4)
                    // Switch case for the Goal Menu
                    {
                        goalInput = goalChoice.GoalChoice();
                        switch (goalInput)
                        {
                            case 1:
                                // Simple Goal
                                Console.WriteLine("What is the name of your goal?  ");
                                string name = Console.ReadLine();
                                name = textInfo.ToTitleCase(name);
                                Console.WriteLine("What is a short description of your goal?  ");
                                string description = Console.ReadLine();
                                description = textInfo.ToTitleCase(description);
                                Console.Write("What is the amount of points associated with this goal?  ");
                                int points = int.Parse(Console.ReadLine());
                                SimpleGoal simGoal = new SimpleGoal("Simple Goal:", name, description, points);
                                goals.AddGoal(simGoal);
                                goalInput = 4;
                                break;
                            case 2:
                                //Eternal Goal
                                Console.WriteLine("What is the name of your goal?  ");
                                name = Console.ReadLine();
                                name = textInfo.ToTitleCase(name);
                                Console.WriteLine("What is a short description of your goal?  ");
                                description = Console.ReadLine();
                                description = textInfo.ToTitleCase(description);
                                Console.Write("What is the amount of points associated with this goal?  ");
                                points = int.Parse(Console.ReadLine());
                                EternalGoal eterGoal = new EternalGoal("Eternal Goal:", name, description, points);
                                goals.AddGoal(eterGoal);
                                goalInput = 4;
                                break;
                            case 3:
                                //Checklist Goal
                                Console.WriteLine("What is the name of your goal?  ");
                                name = Console.ReadLine();
                                name = textInfo.ToTitleCase(name);
                                Console.WriteLine("What is a short description of your goal?  ");
                                description = Console.ReadLine();
                                description = textInfo.ToTitleCase(description);
                                Console.Write("What is the amount of points associated with this goal?  ");
                                points = int.Parse(Console.ReadLine());
                                Console.Write("How many times does this goal need to be accomplished for a bonus?  ");
                                int numberTimes = int.Parse(Console.ReadLine());
                                Console.Write("What is the bonus for accomplishing it that many times?  ");
                                int bonusPoints = int.Parse(Console.ReadLine());
                                ChecklistGoal chelisGoal = new ChecklistGoal("Check List Goal:", name, description, points, numberTimes, bonusPoints);
                                goals.AddGoal(chelisGoal);
                                goalInput = 4;
                                break;
                            case 4:
                                // Exit
                                break;
                            default:
                                Console.WriteLine($"\nSorry the option you entered is not valid. Try Again.");
                                break;
                        }
                    }
                    break;
                case 2:
                    //List Goals
                    Console.Clear();
                    Console.Write($"\n--- You currently have {goals.GetScore()} point! ---");
                    goals.ListGoals();
                    break;

                case 3:
                    //Save Goals
                    goals.SaveGoals();
                    break;
                case 4:
                    // Load Goals
                    Console.Clear();
                    Console.Write($"\n--- You currently have {goals.GetScore()} point! ---");
                    goals.LoadGoals();
                    break;
                case 5:
                    // Record Event
                    Console.Clear();
                    Console.Write($"\n--- You currently have {goals.GetScore()} point! ---");
                    goals.RecordGoalEvent();
                    break;
                case 6:
                    //Quit
                    Console.WriteLine("\nThank you for using the Eternal Quest Program!\n");
                    break;
                default:
                    Console.WriteLine($"\nSorry the option you entered is not valid. Try Again.");
                    break;

            }
        }

    }
}