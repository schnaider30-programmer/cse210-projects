using System;
using System.Net.Http.Headers;

public class Order
{
    private List<Product> _products = new List<Product>();
    private Customer _buyer;

    public Order()
    {
        
    }
    public Order(Customer buyer, List<Product> newProducts)
    {
        _buyer = buyer;
        if (newProducts != null && newProducts.Count > 0)
        {
            _products.AddRange(newProducts);
        }
    }

    public Order(Customer buyer, Product newProduct)
    {
        _buyer = buyer;
        _products.Add(newProduct);
}

    public void AddProduct(Product newProduct)
    {
        _products.Add(newProduct);
    }

    public void BuyerName(Customer buyer)
    {
        _buyer = buyer;
    }
    public int TotalCostOfOrder()
    {
        int total = 0;
        foreach (Product product in _products)
        {
            total += product.TotalCost();
        }

        if (_buyer.LiveInUsa())
        {
            total += 5;
        }
        else
        {
            total += 35;
        }

        return total;
    }
    public string OrderPAckingLabel()
    {
        string label = "";
        foreach (Product product in _products)
        {
            label += $"{product.GetProductName()} | {product.GetProductId()}\n";
        }
        return label;
    }

    public string OrderShippingLabel()
    {
        return $"{_buyer.GetCustomerName()}\n{_buyer.GetCustomerAdress()}";
        
    }

}