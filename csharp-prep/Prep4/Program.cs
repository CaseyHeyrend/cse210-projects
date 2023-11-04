//C# Prep 4—Lists
using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter a list numbers (type 0 is to finish.)");
        List<int> numbers = new List<int>();
        int userNum = -1;
        while (userNum !=0)
    {
        Console.Write("Enter a number: ");
        string userResp = Console.ReadLine();
        userNum = int.Parse(userResp);

        if (userNum != 0)
        {
            numbers.Add(userNum);
        }

    }

    //Sum
    int sum = 0;
    foreach (int number in numbers)
    {
        sum += number;
    }
    Console.WriteLine($"The sum is: {sum}");
    //Average
    float average = ((float)sum) / numbers.Count;
    Console.WriteLine($"The average is: {average}");

    //Max
    int max = numbers[0];
    foreach (int number in numbers)
    {
        if (number > max)
        {
            //This only apply when the numbers is greater then the max
            max = number;
        }
    }
    Console.WriteLine($"The max is: {max}");

    }
}