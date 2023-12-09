using System;
using System.Net.Sockets;

public class Event
{
    //Attributes
    private string _title;
    private string _description;
    private string _date;
    private string _time;
    private Address _address;

    //Constructors
    public Event(string title, string description, string date, string time, Address address)
    {
        _title = title;
        _description = description;
        _date = date;
        _time = time;
        _address = address;
    }

    //Methods
    public string GenerateStandardDet()//GetStandardDetails
    {
        string standard = "Title: " + _title + "\n";
        standard += "Description: " + _description + "\n";
        standard += _date + " | " + _time + "\n";

        string address = _address.GenerateFullAddress();
        standard += address;
        return standard;
    }
    public string GenerateShortDes()//GetShortDescription
    {
        string shortM = "Title: " + _title + "\n";

        shortM += _date + "\n";
        return shortM;

    }
}