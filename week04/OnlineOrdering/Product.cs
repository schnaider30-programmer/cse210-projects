using System;

public class Product
{
    private string _name;
    private string _productId;
    private int _price;
    private int _quantity;

    public Product()
    {
    
    }
    public Product(string name, string id, int price, int quantity)
    {
        _name = name;
        _productId = id;
        _price = price;
        _quantity = quantity;
    }

    public void SetName(string name)
    {
        _name = name;
    }
    public void SetProductId(string id)
    {
        _productId = id;
    }
    public void SetPricePerUnit(int pricePerUnit)
    {
        _price = pricePerUnit;
    }
    public void SetQuantity(int quantity)
    {
        _quantity = quantity;
    }

    public int TotalCost()
    {
        return _price * _quantity;
    }

    public string GetProductName()
    {
        return _name;
    }
    public string GetProductId()
    {
        return _productId;
    }
}
