//Exercise
using System;

class Program
{
    static void Main(string[] args)
    {
        //Console.WriteLine("Hello Foundation4 World!");
        List <Exercise> exeList = new List<Exercise>();
        
        Running running = new Running("June 17, 2024", 30, 5);
        exeList.Add(running);

        Cycling stationaryBicycles = new Cycling("June 19, 2024", 60, 15);
        exeList.Add(stationaryBicycles);
        
        Swimming swimlaps = new Swimming("June 21, 2024", 20, 20);
        exeList.Add(swimlaps);

        Console.WriteLine("Exercises: ");
        Console.WriteLine();

        foreach (Exercise exercise in exeList)
        {
            Console.WriteLine(exercise.GetSummary());
        }
    }
}