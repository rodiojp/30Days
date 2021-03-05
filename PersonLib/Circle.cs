using System;

namespace PersonLib
{
    public class Circle : Shape
    {
        public Circle(double radius, ShapeColor color)
        {
            Radius = radius;
            _Sides = 0;
            Color = color;
        }
        public double Radius { get; private set; }
        public override double Area { get { return Math.PI * Radius * Radius; } }
        public override double Perimeter { get { return Math.PI * Radius * 2; } }
    }
}