using System;

namespace PersonLib
{
    public struct ShapeColor
    {
        public byte R { get; private set; }
        public byte G { get; private set; }
        public byte B { get; private set; }
        public ShapeColor(byte red, byte green, byte blue)
        {
            R = red;
            G = green;
            B = blue;
        }
        public static ShapeColor Red
        {
            get { return new ShapeColor(255, 0, 0); }
        }
        public static ShapeColor Green
        {
            get { return new ShapeColor(0, 255, 0); }
        }
        public static ShapeColor Blue
        {
            get { return new ShapeColor(0, 0, 255); }
        }
        public static ShapeColor Black
        {
            get { return new ShapeColor(0, 0, 0); }
        }
        public static ShapeColor White
        {
            get { return new ShapeColor(255, 255, 255); }
        }

        public override bool Equals(object obj) =>
            obj is ShapeColor mys
            && mys.R == this.R
            && mys.G == this.G
            && mys.B == this.B;

        public static bool operator ==(ShapeColor color1, ShapeColor color2)
        {
            return color1.Equals(color2);
        }
        public static bool operator !=(ShapeColor color1, ShapeColor color2)
        {
            return !color1.Equals(color2);
        }

        public override string ToString()
        {

            if (R == 255 && G == 0 & B == 0) return "Red";
            else if (R == 0 && G == 255 & B == 0) return "Green";
            else if (R == 0 && G == 0 & B == 255) return "Blue";
            else if (R == 0 && G == 0 & B == 0) return "Black";
            else if (R == 255 && G == 255 & B == 255) return "White";
            else return $"R:{R} G:{G} B:{B}";
        }
    }
}