using System;

public class Lecture : Event
{
    //Attributes
    private string _speaker;
    private int _capacity;
 
    //Constructors
    public Lecture(string title, string description, string date, string time, Address address, string speaker, int capacity) : base(title, description, date, time, address)
    {
        _speaker = speaker;
        _capacity = capacity;
    }
    //Methods
    public string GetSpeaker()
    {
        return _speaker;
    }
    public int GetCapacity()
    {
        return _capacity;
    }
    public string ReturnEventType()
    {
        return "Lectures";
    }
    public string GenerateDetailLect()//GetFullDetails
    {
        string detailed = GenerateStandardDet() + "\n";

        detailed += "Speaker: " + _speaker + "\n";
        detailed += "Capacity: " + _capacity +  " max";
        return detailed;
    }
    public string GenerateShortLect()
    {
        string shortLecture = "";
        string eventType = ReturnEventType();

        shortLecture += "Event Type: " + eventType + "\n";
        shortLecture += GenerateShortDes();
        return shortLecture;
    }
}