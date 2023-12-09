using System;

public class Address
{
    //Attributes
    private string _street;
    private string _city;
    private string _state;
    private string _country;

    //Constructors
    public Address(string street, string city, string state, string country)
    {
        _street = street;
        _city = city;
        _state = state;
        _country = country;

    }

    //Methods
    public bool IsUSA()//IsUSAAddress()
    {
        return _country == "USA" ? true : false;
    }
    public string GenerateAddress()//GetFullAddress()
    {
        string address = _street + ", " + _city + "\n" + _state + ", " + _country;
        return address;
    }
}