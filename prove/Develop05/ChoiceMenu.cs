using System;

// The main Program will be cleaner and simpler.
//This is the main Menu.
public class ChoiceMenu
{
    // Attributes 
    private string _choice = $@"
    Main Menu Options
    *******************************************
    Please select one of the following options:
    1. Greate New Goal
    2. List Goals
    3. Save Goals
    4, Load Goals
    5. Record Goal Event
    6. Quit
    *******************************************
    Select an option from the menu: ";

        public string _userInput;
        private int _userChoice = 0;

        //Methods
        public int UserChoice()
        {
            Console.Write(_choice);

            _userInput = Console.ReadLine();
            _userChoice = 0;

            try
            {
                _userChoice = int.Parse(_userInput);
            }
            catch (FormatException)
            {
                _userChoice = 0;
            }
            catch (Exception exception)
            {
                Console.WriteLine($"Unexected error : {exception.Message}");
            }
            return _userChoice;
        }
}