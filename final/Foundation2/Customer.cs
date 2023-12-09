using System;

public class Customer
{
    //Attributes
    private string _name;
    private Address _address;
    //Constructors
    public Customer(string name, Address address)
    {
        _name = name;
        _address = address;
    }
    //Methods
    public bool IsFromUSA()
    {
        return _address.IsUSA() ? true : false;
    }
    public string GetName()
    {
        return _name;
    }
    public string GenerateAddress()
    {
        string generatedAddress = _address.GenerateAddress();
        return generatedAddress;
    }
}