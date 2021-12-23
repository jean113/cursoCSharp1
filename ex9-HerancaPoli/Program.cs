using System;
using System.Collections.Generic;
using System.Globalization;

namespace ex9_HerancaPoli
{
    class Program
    {
        static void Main(string[] args)
        {
            string name, opcao;
            double price, customFee;
            int qtd;
            DateTime manufactureDate;
            List<Product> produtos = new List<Product>();
            ImportedProduct ip;
            UsedProduct up;
            Product p;

            Console.WriteLine("Enter the number of products: ");
            qtd = int.Parse(Console.ReadLine());

            Console.WriteLine();

            for(int i=0 ;i < qtd; i++)
            {
                Console.WriteLine($"Product #{i+1}: ");  

                Console.Write("Commom, used or imported (c/u/i)? "); 
                opcao = Console.ReadLine();

                Console.Write("Name "); 
                name = Console.ReadLine();

                Console.Write("Price "); 
                price = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                if (opcao == "i")
                {
                    Console.Write("Customs fee: "); 
                    customFee = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                    ip = new ImportedProduct(name, price, customFee);
                    produtos.Add(ip);
    
                }

                else if (opcao == "u")
                {
                    Console.Write("Manufacture date (DD/MM/YYYY): "); 
                    manufactureDate = DateTime.Parse(Console.ReadLine());

                    up = new UsedProduct(name, price, manufactureDate);
                    produtos.Add(up);
                }
                else
                {
                    p = new Product(name, price);
                    produtos.Add(p);
                }

            }

            Console.WriteLine();
            Console.WriteLine("PRICE TAGS:"); 

            foreach(Product prod in produtos)
            {
                if (prod is ImportedProduct)
                {
                    ip = (ImportedProduct)prod;                
                    Console.WriteLine(ip.priceTag());
                } 
                else if (prod is UsedProduct)
                {
                    up = (UsedProduct)prod;
                    Console.WriteLine(up.priceTag());
                } 
                else
                {
                    Console.WriteLine(prod.priceTag());
                } 

            }

        }
    }
}
