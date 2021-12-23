using System;
using System.Globalization;

namespace Interfaces    
{
    class Rectangle : AbstractShape
    {
        public double Width {get; set;}
        public double Height {get; set;}

        public Rectangle(double w, double h, Color c) : base(c)
        {
            Width = w;
            Height = h;
        }

        public override double Area()
        {
            return Width * Height;
        }

        public override string ToString()
        {
            return "Color Rectangle " + Color + " Width " + 
                Width.ToString("F2", CultureInfo.InvariantCulture) + " Height " + 
                Height.ToString("F2", CultureInfo.InvariantCulture) + " Area " + 
                Area().ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}