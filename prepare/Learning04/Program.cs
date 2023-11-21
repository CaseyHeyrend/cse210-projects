using System;

class Program
{
    static void Main(string[] args)
    {
        //Console.WriteLine("Hello Learning04 World!");
        // Name and Topic
        Assignment assign1 = new Assignment("Samuel Bennett","Multiplication" );
        
        Console.WriteLine(assign1.GetSummary());

        // Name, Topic, Textbook, Problems
        MathAssignment math = new MathAssignment("Roberto Rodriquez", "Fractions", "7.3", "8-19");
        Console.WriteLine(math.GetSummary());
        Console.WriteLine(math.GetHomeworkList());
        
        //Name, Topic, Title
        WritingAssignment write = new WritingAssignment("Mary Waters", "European History", "The Causes of World War II");
        Console.WriteLine(write.GetSummary());
        Console.WriteLine(write.GetWritingInformation());



    }

}