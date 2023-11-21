using System;

public class MathAssignment : Assignment
{
     //Attributes
    private string _textbookSection = "";
    private string _problems = "";

    public MathAssignment()
    {

    }
    public MathAssignment(string studentName, string topic, string textbookSection, string problems)
        : base(studentName, topic)
    {
        // Varibles for Math.
        _textbookSection = textbookSection;
        _problems = problems;
    }
    public string GetTextBookSection()
    {
        return _textbookSection;
    }
    public void SetTextBookSection(string textbookSection)
    {
        _textbookSection = textbookSection;
    }
    public string GetProblems()
    {
        return _problems;
    }
    public void SetProblems(string problems)
    {
        _problems = problems;
    }

    public string GetHomeworkList()
    {
        return $"Section: {_textbookSection} Problems: {_problems}";

    }

}