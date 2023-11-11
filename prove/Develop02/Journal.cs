using System;
using System.Text.Json;


public class Journal
{
    public List<JournalEntry> _journal = new List<JournalEntry>();
    private string  _userFileAlias;
    
    

    public Journal()
    {
    }

    public void Display()
    {
        Console.WriteLine("Journal Entries");
        foreach (JournalEntry journalEntry in _journal)
        {
            journalEntry.Display();
        }
        Console.WriteLine("End");
    }
    public void CreateJournalFile()
    {
        Console.Write("What is your file name? ");
        string userInput = Console.ReadLine();
        _userFileAlias = userInput + ".txt";

        if (!File.Exists( _userFileAlias))
        {
            File.CreateText( _userFileAlias);
            Console.Write($"{ _userFileAlias} has been made! ");
            Console.Write("Your Entries have been Saved");
            SaveJournalFile( _userFileAlias);
            CreateJSON(userInput);
        }
        else 
        {
            Console.Write($"{_userFileAlias} Exists already");
            Console.Write("Entries have been added.");
            AppendJournalFile(_userFileAlias);
        }
    }

    public void SaveJournalFile(string _userFileAlias)
    {
        using (StreamWriter outputFile = new StreamWriter(_userFileAlias))
        {
            foreach (JournalEntry journalEntry in _journal)
            {
                outputFile.WriteLine($"{journalEntry._date}; {journalEntry._journalEntry}; {journalEntry._journalPrompt}");
            }
        }
    }
    public void AppendJournalFile(string _userFileAlias)
    {
        using (StreamWriter outputFile = new StreamWriter (_userFileAlias, append:true))
        {
            foreach (JournalEntry journalEntry in _journal)
            {
                outputFile.WriteLine($"{journalEntry._date}; {journalEntry._journalEntry}; {journalEntry._journalPrompt}");
            }
        }
    }
    public void LoadJournalFile()
    {
        Console.Write("What is the file name? ");
        string userInput = Console.ReadLine();
        _userFileAlias = userInput + ".txt";

        if (File.Exists(_userFileAlias))
        {
            List<string> readText =File.ReadAllLines(_userFileAlias).Where(arg => !string.IsNullOrWhiteSpace(arg)).ToList();
            foreach (string line in readText)
            {
                string[] entries = line.Split("; ");

                JournalEntry entry = new JournalEntry();

                entry._date = entries[0];
                entry._journalPrompt = entries [1];
                entry._journalEntry = entries [2];

                _journal.Add(entry);
            }
        }
    }


    public void CreateJSON(string userInput)
    {
        string fileName = userInput + ".json";
        List<JsonThingy>_data = new List<JsonThingy>();

        foreach (JournalEntry journalEntry in _journal)
        {
            _data.Add(new JsonThingy()
            {
                Date = journalEntry._date,
                Entry = journalEntry._journalEntry,
                Prompt = journalEntry._journalPrompt
            });
        }
        string json = JsonSerializer.Serialize(_data);
        File.WriteAllText(fileName, json);
    }

}

        