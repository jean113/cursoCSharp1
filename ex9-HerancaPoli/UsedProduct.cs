using System;
using System.Globalization;

namespace ex9_HerancaPoli
{
    class UsedProduct : Product
    {
        public DateTime ManufactureDate { get;  set;}
        
        public UsedProduct(string name, double price, DateTime manufactureDate) : base(name, price)
        {
            ManufactureDate = manufactureDate;
        }

        public override string priceTag()
        {
            return base.Name + " (used) " + base.Price.ToString("F2", CultureInfo.InvariantCulture) + 
                $" (Manufacture Date: {ManufactureDate.ToString("dd/MM/yyyy")})";
        }

    }
    
}