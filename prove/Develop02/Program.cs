using System;
using System.IO;

// This is the Class Prompts
class JournalPrompt{
    public static string[] _prompt = 
    {
        "Who was the most interesting person I interacted with today?",
        "What was the best part of my day?",
        "How did I see the hand of the Lord in my life today?",
        "What was the strongest emotion I felt today?",
        "If I had one thing I could do over today, what would it be?",
        "What did you do day?",
        "What did you dream about last night? ",
        "What did you see outside today?",
        "Did you leave the house today? If so answer y/n."
    };
    public List<string> _journalPrompt = new List<string>(_prompt);

    public void Display()
    {
        var random = new Random();
        int index = random.Next(_journalPrompt.Count);
        string journalPrompt = _journalPrompt[index];
        Console.WriteLine($"{_journalPrompt}");
    }
    public string GetPrompt()
    {
        var random = new Random();
        int index = random.Next(_journalPrompt.Count);
        string journalPrompt = _journalPrompt[index];

        return journalPrompt;
    }
}
class Program
{
    static void Main(string[] args)
    {
        //Prompts
        
        Console.WriteLine("Welcome to Journal App");
        //Writing a Journal Entry
        

    }
}