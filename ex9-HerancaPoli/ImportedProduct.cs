using System;
using System.Globalization;

namespace ex9_HerancaPoli
{
    class ImportedProduct : Product
    {
        public double CustomFee { get;  set;}

        public ImportedProduct(string name, double price, double customFee) : base(name, price)
        {
            CustomFee = customFee;
        }

        public double totalPrice()
        {
            return base.Price += CustomFee;
        }

        public override string priceTag()
        {
            return base.Name + " " + totalPrice().ToString("F2", CultureInfo.InvariantCulture) + $" (Custom fee: {CustomFee.ToString("F2", CultureInfo.InvariantCulture)} )" ;
        }
    }
    
}