using System;
using System.Collections.Generic;
using System.Text;
using System.Globalization;

namespace ex8
{
   class Order
   {
       public DateTime Moment {get;set;}
       public OrderStatus Status {get;set;}
       public List<OrderItem> Items;
       public Client Client{get;set;}

       public Order(DateTime moment, OrderStatus status, Client client)
       {
            Moment = moment;
            Status = status;
            Items = new List<OrderItem>();
            Client = client;
       }

       public void addItem(OrderItem item)
       {
           Items.Add(item);
       }

       public void removeItem(OrderItem item)
       {
           Items.Remove(item);
       }

       public double total()
       {
           double total = 0;

           foreach(OrderItem item in Items)
           {
               total += item.subTotal();
           }

           return total;
       }

       public override string ToString()
       {
           StringBuilder texto = new StringBuilder();
           texto.AppendLine("Momento Ordem: " + Moment);
           texto.AppendLine("Status: " + Status );
           texto.AppendLine("Cliente: " + Client );
           texto.AppendLine("Order Items");

           foreach(OrderItem item in Items)
           {
               texto.AppendLine(item.ToString());
           }

           texto.AppendLine("Total do valor: " + total().ToString("F2", CultureInfo.InvariantCulture));

           return texto.ToString();
       }

   }
}