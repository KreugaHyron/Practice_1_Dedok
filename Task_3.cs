using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice_1_Dedok
{
    //for task 3
    abstract class Figure
    {
        public abstract double CalculateArea();
        public abstract override int GetHashCode();
    }
    class Rectangle : Figure
    {
        public double Width { get; set; }
        public double Height { get; set; }

        public Rectangle(double width, double height)
        {
            Width = width;
            Height = height;
        }
        public override double CalculateArea()
        {
            return Width * Height;
        }
        public override int GetHashCode()
        {
            return Width.GetHashCode() ^ Height.GetHashCode();
        }
    }
    class Circle : Figure
    {
        public double Radius { get; set; }

        public Circle(double radius)
        {
            Radius = radius;
        }
        public override double CalculateArea()
        {
            return Math.PI * Radius * Radius;
        }
        public override int GetHashCode()
        {
            return Radius.GetHashCode();
        }
    }
    class RightTriangle : Figure
    {
        public double Base { get; set; }
        public double Height { get; set; }

        public RightTriangle(double @base, double height)
        {
            Base = @base;
            Height = height;
        }
        public override double CalculateArea()
        {
            return 0.5 * Base * Height;
        }
        public override int GetHashCode()
        {
            return Base.GetHashCode() ^ Height.GetHashCode();
        }
    }
    class Trapezoid : Figure
    {
        public double Base1 { get; set; }
        public double Base2 { get; set; }
        public double Height { get; set; }

        public Trapezoid(double base1, double base2, double height)
        {
            Base1 = base1;
            Base2 = base2;
            Height = height;
        }
        public override double CalculateArea()
        {
            return 0.5 * (Base1 + Base2) * Height;
        }
        public override int GetHashCode()
        {
            return Base1.GetHashCode() ^ Base2.GetHashCode() ^ Height.GetHashCode();
        }
    }
}
