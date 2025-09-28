using System;
using System.Net.Sockets;

public class Customer
{
    string _customerName;
    Address _address;

    public Customer()
    {
        _customerName = "";
        _address = new Address(); // Assumes Address has a default constructor
    }
    public Customer(string name, Address address)
    {
        _customerName = name;
        _address = address;
    }

    public void SetCustomerName(string name)
    {
        _customerName = name;
    }

    public void SetCustomerAdress(Address address)
    {
        _address = address;
    }
    public bool LiveInUsa()
    {
        return _address.LiveInUsa();
    }

    public string GetCustomerName()
    {
        return _customerName;
    }

    public string GetCustomerAdress()
    {
        return _address.GetFullAddress();
    }
}