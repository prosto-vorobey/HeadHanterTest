using System;
using System.Drawing;

namespace HeadHanterTestLibrary
{
    public class NoTypeShape
    {
        public NoTypeShape() { }
        public double GetArea (params double[] side)
        {
            Shape sh;
            switch (side.Length)
            {
                case 1:
                    sh = new Circle();
                    return sh.GetArea(side);
                case 3:
                    sh = new Triangle();
                    return sh.GetArea(side);
                default:
                    return 0;
            }
        }
    }
}
