using System;

public class Product
{
    //Attributes
    private string _name;
    private string _productID;
    private double _price;
    private int _quantity;

    //Constructors
    public Product(string name, string productID, double price, int quantity)
    {
        _name = name;
        _productID = productID;
        _price = price;
        _quantity = quantity;
    }
    //Methods
    public double CalculatePrice()
    {
        return _price * _quantity;

    }
    public string GetName()
    {
        return _name;
    }
    public string GetProductID()
    {
        return _productID;
    }
    public double GetPrice()
    {
        return _price;
    }
    public int GetQuantity()
    {
        return _quantity;
    }
}