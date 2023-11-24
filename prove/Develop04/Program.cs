using System;
using System.Diagnostics;

class Program
{
    static void Main(string[] args)
    {
        //Console.WriteLine("Hello Develop04 World!");
        Console.Clear();
        Console.WriteLine("Welocome to the Mindfulness Program!");

        //Call the Choices
        Choices choice = new Choices();

        int breatheCount = 0;
        int reflectCount = 0;
        int listCount = 0;

        Console.WriteLine();
        int motion = 0;
        while (motion != 4)
        {
            motion = choice.UserChoice();
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