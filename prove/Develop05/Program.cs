using System;
using System.IO;
using System.Globalization;

class Program
{
    static void Main(string[] args)
    {
        //Console.WriteLine("Hello Develop05 World!");
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
                    Console.Clear();
                    int goalInput = 0;
                    while (goalInput != 5)
                    // Switch case for the Goal Menu
                    {
                        goalInput = goalChoice.GoalChoice();
                        switch (goalInput)
                        {
                            case 1:
                                // Simple Goal
                                break;
                            case 2:
                                //Eternal Goal
                                break;
                            case 3:
                                //Checklist Goal
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
                    goals.RecordEventInManager();
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