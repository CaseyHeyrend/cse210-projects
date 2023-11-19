using System;

// Code Template for the category for text known as ...
public class Word
{
    //The Variables
    private string _text;
    private bool _isHidden;
    // Methods

    public Word(string text)
    {
        this._text = text;
        _isHidden = false;
    }
    public void Hide()
    {
        _isHidden = true;
    }
    public string GetText()
    {
        return _text;
    }
    public bool IsHidden()
    {
        return _isHidden;
    }
}