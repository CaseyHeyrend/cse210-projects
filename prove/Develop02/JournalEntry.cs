using System;


public class JournalEntry
{
    public string _date = "";
    public string _journalEntry = "";
    public string _journalPrompt = "";
    



public JournalEntry()
{

}

public void Display()
{
    Console.WriteLine($"Date: {_date}");
    Console.WriteLine($"Entry: {_journalEntry}");
    Console.WriteLine($"Prompt: {_journalPrompt}");
    
}
}
