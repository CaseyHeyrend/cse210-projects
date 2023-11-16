using System;

// Code Template for the category for text known as ...
public class Scripture
{
    // The Variables
    public List<Scripture> _scripture = new List<Scripture>();
    private string _FileAlias = "Versestext.txt";
    private string _key;
    private string _text;
    public int _index;
    public string _scriptureVerses;
    
    //The Methods
    public void LoadScriptures()
    {
        List<string> readText = File.ReadAllLines(_FileAlias).Where(arg => !string.IsNullOrWhiteSpace(arg)).ToList();

        foreach (string line in readText)
        {
            string[] entries = line.Split(";");
            Scripture entry = new Scripture();

            entry._key = entries[0];
            entry._text = entries[6];

            _scripture.Add(entry);
        }
    }
    public void ScriptureDisplay()
    {
        foreach (Scripture item in _scripture)
        {
            item.ShowScripture();
        }
    }

    public void ShowScripture()
    {
        Console.WriteLine($"{_text}");
    }

    public int GetRandomIndex()
    {
        var random = new Random();
        _index = random.Next(_scripture.Count);
        return _index;
    }

    public string RandomScripture()
    {
        _index = GetRandomIndex();
        return _scriptureVerses = _scripture[_index]._text;
    }
    public void HideWords()
    {

    }
    public void GetRenderedText()
    {

    }
    public void IsCompleteHidden()
    {

    }
    

}