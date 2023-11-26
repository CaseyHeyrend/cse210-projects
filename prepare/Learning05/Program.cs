using System;

class Program
{
    static void Main(string[] args)
    {
        //Console.WriteLine("Hello Learning05 World!")
        List<Shape> shapes = new List<Shape>();

        Square s1 = new Square("Red", 5);
        shapes.Add(s1);

        Rectangle s2 = new Rectangle("Green", 5, 10);
        shapes.Add(s2);

        Circle s3 = new Circle("Blue", 5);
        shapes.Add(s3);

        foreach (Shape s in shapes)
        {
            string color = s.GetColor();
            double area = s.GetArea();
            string sType = s.GetShapeType();

            Console.WriteLine($"The {sType} is {color} and has an area of {area}.");
        }


    }
    
}