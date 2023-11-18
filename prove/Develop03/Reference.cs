using System;

// Code Template for the category for text known as ...
public class Reference 
{
    //The Variables
    public List<Reference> _reference = new List<Reference>();
    private string _FileAlias = "Versestext.txt";
    private string _key;
    private string _book;
    private int _chapter;
    private int _verseStart;
    private int _verseEnd;

    // The Methods
    public void LoadReference()
    {
        List<string> readText = File.ReadAllLines(_FileAlias).Where(arg => !string.IsNullOrWhiteSpace(arg)).ToList();

        foreach (string line in readText)
        {
            string[] entries = line.Split(";");
            Reference entry = new Reference();

            entry._key = entries[0];
            entry._book = entries[1];
            entry._chapter = int.Parse(entries[2]);
            entry._verseStart = int.Parse(entries[3]);
            entry._verseEnd = int.Parse(entries[4]);

            _reference.Add(entry);
        }
    }
    public void ReferenceDisplay()
    {
        foreach (Reference item in _reference)
        {
            if (item._verseEnd.Equals(0))
            {
                item.ReferenceOne();
            }
            else
            {
                item.ReferenceTwo();
            }
        }
    }
    public string GetReference(Scripture scripture)
    {
        var index = scripture._index;
        var referi = _reference[index];
        string refer1;
        
        if (referi._verseEnd.Equals(0))
        {
            return refer1 = ($"{referi._book} {referi._chapter}:{referi._verseStart}");
        }
        else
        {
            return refer1 = $"{referi._book} {referi._chapter}:{referi._verseStart}-{referi._verseEnd}";
        }
    }
    public void ReferenceOne()
    {
        Console.WriteLine($"{_book} {_chapter}:{_verseStart}");
    }
    public void ReferenceTwo()
    {
        Console.WriteLine($"{_book} {_chapter}:{_verseStart}-{_verseEnd}");
    }
}