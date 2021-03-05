using System;

namespace PersonLib
{
    public class Square : Shape
    {
        public Square(double sideLength, ShapeColor color)
        {
            SideLength = sideLength;
            _Sides = 4;
            Color = color;
        }
        public double SideLength { get; private set; }
        public override double Area { get { return SideLength * SideLength; } }
        public override double Perimeter { get { return SideLength * _Sides; } }
    }
}