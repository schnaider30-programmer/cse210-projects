using System;

class Program
{
    static void Main(string[] args)
    {
        Shape rect = new Rectangle("blue",16, 16);
        string color = rect.GetColor();
        double area = rect.GetArea();
        Square sq = new Square("red", 16);
        string color1 = sq.GetColor();
        double area1 = sq.GetArea();
        Shape circ = new Circle("purple", 16);
        string color2 = circ.GetColor();
        double area2= circ.GetArea();

        List<Shape> shapes = new List<Shape>();

        shapes.Add(rect);
        shapes.Add(circ);
        shapes.Add(sq);

        foreach (Shape s in shapes)
        {
            Console.WriteLine(s.GetColor());
            Console.WriteLine(s.GetArea());
        }
    }
}