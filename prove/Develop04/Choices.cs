using System;

// The Choices and to kept the main simple
 public class Choices
 {
    private string _menu =@"
    Please select one of the follow activities: 
        1. Breathing Activity
        2. Reflecting Activity
        3. Listing Activity
        4. Quit
        What would you like to do? ";

        public string _userInput;
        private int _userChoice = 0;

        public int UserChoice()
        {
            Console.Clear();
            Console.Write(_menu);

            _userInput = Console.ReadLine();
            _userChoice = 0;

            // catches any non int values
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
                Console.WriteLine($"Unexpected error:  {exception.Message}");
             }
             return _userChoice;
             }


}