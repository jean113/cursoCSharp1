using System;
using System.Globalization;

namespace ex9_HerancaPoli
{
    class Product
    {
        public string Name { get;  set;}
        public double Price { get;  set;}

        public Product(string name, double price)
        {
            Name = name;
            Price = price;
        }

        public virtual string priceTag()
        {
            return Name + "  " + Price.ToString("F2", CultureInfo.InvariantCulture);
        }

    }
    
}