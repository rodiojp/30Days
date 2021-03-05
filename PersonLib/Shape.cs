using System;

namespace PersonLib
{
    public abstract class Shape
    {
        public abstract double Area { get; }
        public virtual int Sides { get { return _Sides; } }
        protected int _Sides;

        public abstract double Perimeter { get; }

        public ShapeColor Color { get; set; }

    }
}