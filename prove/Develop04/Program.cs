using System;

class Program
{
    public class Options
    {
        private string _menu =@"
            
            Please select one of the follow activities: 
            1. Breathing Activity
            2. Reflecting Activity
            3. Listing Activity
            4. Quit
            What would you like to do?";
             public string _userInput;
             private int _userOptions = 0;

             public int UserOptions()
             {
                Console.Clear();
                Console.Write(_menu);

                _userInput = Console.ReadLine();
                _userOptions = 0;
             
             // catches any non int values
             try 
             {
                _userOptions = int.Parse(_userInput);
             }
             catch (FormatException)
             {
                _userOptions = 0;
             }
             catch (Exception exception)
             {
                Console.WriteLine($"Unexpected error:  {exception.Message}");
             }
             return _userOptions;
             }
    }
    static void Main(string[] args)
    {
        //Console.WriteLine("Hello Develop04 World!");
        Console.Clear();
        Console.WriteLine("Welocome to the Mindfulness Program!");

        //Call the Options
        Options option = Options();

        int breatheCount = 0;
        int reflectCount = 0;
        int listCount = 0;


        
        Console.WriteLine();
        int motion = 0
        while (motion != 4)
        {
            motion = options.UserOptions();
            switch (motion)
            {
                //Breathing
                case 1: 
                    Console.Clear();
                    BreathingActivity breathing = new BreathingActivity();
                    breathing.RunBreathingActivity();
                    breatheCount++;
                    break;
                //Reflecting
                case 2:
                    Console.Clear();
                    ReflectingActivity reflecting = new ReflectingActivity();
                    reflecting.RunReflectingActivity();
                    reflectCount++;
                    break;
                //Listing
                case 3:
                    Console.Clear();
                    ListingActivity listing = new ListingActivity();
                    listing.RunListingActivity();
                    listCount++;
                    break;
                //quit
                case 4:
                    running = false;
                    Console.WriteLine("Great job! You completed the following activities: ");
                    Console.WriteLine($"Breathing Activity: {breatheCount} times");
                    Console.WriteLine($"Reflecting Activity: {reflectCount} times");
                    Console.WriteLine($"Listing Activity: {listCount} times");
                    Console.WriteLine();
                    Console.WriteLine("Thank you. Have a nice day!");
                    break;
                default:
                    Console.WriteLine("Invaild Input. Try Again.");
                    break;


            }
        }
        
    }
}