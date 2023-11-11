using System;
using System.IO;
using System.Security.Cryptography;

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
        "Did you leave the house today? If so answer y/n.",
        "What is your favorite type of music today?",
        "Would you rather be beautiful, smart, or athletic? Why?",
        "Write about your favorite childhood toy.",
        "Write out the best or the worst day of your life.",
        "Five years from now, I will be...",
        "Invent and describe a new food.",
        "Describe someone who is a hero to you and explain why.",
        "Three goals I have set for myself are...",
        "What did I learn today?",
        "What was the most interesting thing I saw or heard today?",
        "What is the current problem or challenge I am facing?",

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
        int[] vaildNums = {1, 2, 3, 4, 5};
        int effect = 0;
        Console.WriteLine("Welcome to Journal App");
        Journal journal = new Journal();
        JournalPrompt cue = new JournalPrompt();
        //Writing a Journal Entry
        while (effect != 5)
        {
            effect = Options();
            switch (effect)
            {
                //Writing a Journal Entry
                case 1:
                    string dateNow = GetDate();
                    string prompt = cue.GetPrompt();

                    JournalEntry entry = new JournalEntry();
                    entry._date = dateNow;
                    entry._journalPrompt = prompt;

                    Console.Write($"{prompt}");
                    Console.Write($">>>");
                    string userEntry = Console.ReadLine();
                    entry._journalEntry = userEntry;

                    journal._journal.Add(entry);
                    break;
                case 2:
                    journal.Display();
                    break;
                case 3:
                    journal.LoadJournal();//File
                    break;
                case 4:
                    journal.CreateJournal();
                    break;
                case 5:
                    Console.WriteLine("Thank you for usisg the Journal App!");
                    break;
                default:
                    Console.WriteLine($"Wrong Options. Try again.");
                    break;
            }

        }
        
    }
    static int Options()
    {
        string options = @"
        Please select one of the following options:
        1.Write
        2.Display
        3.Load
        4.Save
        5.Quit
        So What would you like to do? ";

        Console.Write(options);
        string userInput = Console.ReadLine();
        int effect = 0;

        try 
        {
            effect = int.Parse(userInput);
        }
        catch(FormatException)
        {
            effect = 0;
        }
        catch (Exception exception)
        {
            Console.WriteLine($"Unexpexted error: {exception.Message}");
        }
        return effect;
    }
    static string GetDate()
    {
        DateTime now = DateTime.Now;
        string currentDate = now.ToString("F");
        return currentDate;
    }
}