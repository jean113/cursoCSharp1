using System;
using System.Globalization;

namespace ex8
{
    class OrderItem
    {
        public int Quantify {get; set;}
        public double Price {get; set;}
        public Product Product {get; set;}

        public OrderItem(int quantify, double price, Product product)
        {
            Quantify = quantify;
            Price = price;
            Product = product;
        }  

        public double subTotal()
        {
            return Quantify * Price;
        }

        public override string ToString()
        {
            return Product +", " +  Price  + ", Quantidade: " + Quantify +", SubTotal: " + subTotal().ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}
