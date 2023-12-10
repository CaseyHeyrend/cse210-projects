using System;

public class Comment
{
    //Attributes 
    private string _name;
    private string _text;
    
    //Constructors
    public Comment(string name, string text)
    {
        _name = name;
        _text = text;

    }
    //Methods

    public void DisplayInfo()
    {
        Console.WriteLine($"{_name} - {_text}");
    }
}
