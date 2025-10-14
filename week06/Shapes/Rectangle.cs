using System;
using System.ComponentModel.DataAnnotations;
using System.Drawing;

public class Rectangle : Shape
{
    double _length;
    double _width;

    public Rectangle(string color, double length, double width) : base(color)
    {
        _length = length;
        _width = width;
    }

    public override double GetArea()
    {
        return _width * _length;
    }
    
}