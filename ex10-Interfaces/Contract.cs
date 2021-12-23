using System;

namespace ex10_Interfaces
{
    class Contract : IServiceInstallment
    {
        public int Numero {get; set;}
        public DateTime Data {get; set;}
        public double Total {get; set;}

        public Contract(int numero, DateTime data, double total)
        {
            Numero = numero;
            Data = data;
            Total = total;
        }

        public double Calculate(double amount, int month)
        {
            double aux = amount + (amount * 0.01 * month);
            return aux + ( aux * 0.02  );
        }
    }
}