using System;

namespace ex10_Interfaces
{
    class Program
    {
        static void Main(string[] args)
        {
            int number, months;
            DateTime data;
            double total;
            Contract c;

            Console.WriteLine("Enter contract data");
            Console.Write("Number: ");
            number = int.Parse(Console.ReadLine());
            Console.Write("Data: ");
            data = DateTime.Parse(Console.ReadLine());
            Console.Write("Total: ");
            total = double.Parse(Console.ReadLine());

            c = new Contract(number, data, total);

            Console.Write("Enter number of Installments: ");
            months = int.Parse(Console.ReadLine());

            Console.WriteLine("Installments");
            for(int i=1 ; i <= months; i++)
            {
                Console.WriteLine(c.Data.AddMonths(i) + " - " + c.Calculate(  (total / months ), i ));
            }


            
        }
    }
}
