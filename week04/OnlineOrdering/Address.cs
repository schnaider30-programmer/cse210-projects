using System;
using System.Runtime.CompilerServices;

public class Address
{
    string _streetadress;
    string _city;
    string _state;
    string _country;

    public Address()
    {
        _streetadress = "";
        _city = "";
        _state = "";
        _country = "";
    }
    public Address(string streetAdress, string city, string country)
    {
        _streetadress = streetAdress;
        _city = city;
        _country = country;
    }
    public Address(string streetAdress, string city, string state, string country)
    {
        _streetadress = streetAdress;
        _city = city;
        _state = state;
        _country = country;
    }
    public void SetStreet(string street)
    {
        _streetadress = street;
    }
    public void SetCity(string city)
    {
        _city = city;
    }
    public void SetCountry(string country)
    {
        _country = country;
    }
    public void SetState(string state)
    {
        _state = state;
    }

    public bool LiveInUsa()
    {
        return _country.ToLower() == "usa" || _country.ToLower() == "united states" || _country.ToLower() == "united states of america";
    }

    public string GetFullAddress()
    {
        if (_state != null) { return $"{_streetadress}, \n{_city}, {_state}, \n{_country}";}
        else
        {
            return $"{_streetadress}, \n{_city}, \n{_country}";
        
        }
    }
}   
