//C# Prep 3—Loops
using System;

class Program
{
    static void Main(string[] args)
    {
        
        //Console.WriteLine($"What is the magic number?");
        //int magiNum = int.Parse(Console.ReadLine()) ;

        //Random Mode
        Random randomGen = new Random();
        int magiNum = randomGen.Next(1, 101);
       
        int guess = -1;

        while (guess != magiNum)
        {
            Console.Write($"What is your guess? ");
            guess = int.Parse(Console.ReadLine());

            if (magiNum > guess)
            {
                Console.WriteLine("Higher");
            }
            else if (magiNum < guess)
            {
                Console.WriteLine("Lower");
            }
            else
            {
                Console.WriteLine("Good job, You have guess it!");
            }
        }


    }
}