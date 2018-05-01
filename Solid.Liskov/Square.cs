using System;
namespace Solid.Liskov
{
    public class Square : Shape
    {
        public double SideLength;

        public override double Area()
        {
            return SideLength * SideLength;
        }
    }
}
