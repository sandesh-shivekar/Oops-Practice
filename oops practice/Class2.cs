using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


//method overloading

class Area
{
    public void area(int s)
    { 
        Console.WriteLine("Area of square is = " + s * s);
    }
    public void area(int l , int b)
    {
        Console.WriteLine("Area of rectangle is = " + l * b);
    }
    public void area(double r)
    {
        Console.WriteLine("Area of circle is = " + 3.14 * r * r);
    }
    public void area(double a , double b)
    {
        Console.WriteLine("Area of triangle is = " + 0.5 * a * b);
    }

}
class Class2
{
    public static void Main(string[] args)
    {
        Area a = new Area();
        a.area(5);
        a.area(5, 10);
        a.area(7.5);
        a.area(5.0, 10.0);
    }

}

