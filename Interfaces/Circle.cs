using System;
using System.Globalization;

namespace Interfaces    
{
    class Circle : AbstractShape
    {
        public double Radius {get; set;}

        public Circle(double radius, Color c) : base(c)
        {
            Radius = radius;
        }

        public override double Area()
        {
            return Math.PI * Radius * Radius;
        }

        public override string ToString()
        {
            return "Color Circle " + Color + " Radius " + Radius.ToString("F2", CultureInfo.InvariantCulture) + " Area " + Area().ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}