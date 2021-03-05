using System;

namespace PersonLib
{
    public static class ShapeUtility
    {

        public static bool IsPoligon(this Shape shape)
        {
            return shape.Sides > 2;
        }

    }
}