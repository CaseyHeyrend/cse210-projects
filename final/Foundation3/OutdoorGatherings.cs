using System;

public class OutdoorGathering : Event
{
    //Attributes
    private string _weatherFor;//weatherForecast
    //Constructors
    public OutdoorGathering(string title, string description, string date, string time, Address address, string weatherFor) : base(title, description, date, time, address)
    {
        _weatherFor = weatherFor;
    }

    //Methods
    public string GetWeather()
    {
        return _weatherFor;
    }
    public string GenerateWeatherForecast()
    {
        return "The weather will be " + _weatherFor + ".";
    }
    public string ReturnEventType()
    {
        return "Outdoor Gathering";
    }
    public string GenerateDetailOG()//GetFullDetails //Outdoor Gathering
    {
        string detailed = "";
        string weatherStatement = GenerateWeatherForecast();

        detailed += GenerateStandardDet() + "\n";
        detailed += "Statement of the Weather: " + weatherStatement;
        return detailed;
    }
    public string GenerateShortOG()//Outdoor Gathering
    {
        string shortOG = "";
        string eventType = ReturnEventType();

        shortOG += "Event Type: " + eventType + "\n";
        shortOG += GenerateShortDes();
        return shortOG;
    }
}
