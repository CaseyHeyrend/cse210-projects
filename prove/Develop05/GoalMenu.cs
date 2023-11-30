using System;

// The main Program will be cleaner and simpler.
// This is the goal Menu.

public class GoalMenu
{
    // Attributes 
    private string _gMenu = $@"
    Goal Menu Options
    *******************************
    The Types of Goals are:
    1. Simple Goal
    2. Eternal Goal
    3. Checklist Goal
    4. Back to Main
    *******************************
    What type of goal would you like to create? ";

    public string _goalInput;
    private int _goalChoice = 0;
    //Methods
    public int GoalChoice()
    {
        
        Console.Write(_gMenu);
        _goalInput = Console.ReadLine();
        _goalChoice = 0;

        try
            {
                _goalChoice = int.Parse(_goalInput);
            }
            catch (FormatException)
            {
                _goalChoice = 0;
            }
            catch (Exception exception)
            {
                Console.WriteLine($"Unexected error : {exception.Message}");
            }
            return _goalChoice;
    }
}
