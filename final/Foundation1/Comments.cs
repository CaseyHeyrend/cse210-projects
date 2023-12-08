using System;

public class Comment
{
    //Attributes 
    private string _userName;//name
    private string _text;
    
    //Constructors
    public Comment(string username, string text)
    {
        _userName = username;
        _text = text;

    }
    //Methods

    public void DisplayInfo()
    {
        Console.WriteLine($"{_userName} - {_text}");
    }
}