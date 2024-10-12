using System;
using System.Collections.Generic;

public class Product
{
    private string _name;
    private string _productId;
    private double _price;
    private int _quantity;

    public Product(string name, string productId, double price, int quantity)
    {
        _name = name;
        _productId = productId;
        _price = price;
        _quantity = quantity;
    }

    // calculate the total cost of the product
    public double GetTotalCost()
    {
        return _price * _quantity;
    }

    // Get the packing label details for the product
    public string GetPackingLabel()
    {
        return $"{_name} (ID: {_productId})";
    }
}
