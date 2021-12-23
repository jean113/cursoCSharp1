using System;

namespace ex5
{
    class Program
    {
        static void Main(string[] args)
        {
            Conta c;
            string decisao;
            double saldo, saque; 

            c   = new Conta();

            Console.WriteLine("Numero da conta");
            c.Numero = Console.ReadLine();

            Console.WriteLine("Titular da conta");
            c.Titular = Console.ReadLine();

            Console.WriteLine("Vc quer colocar um deposito inicial?(s/n)");
            decisao = Console.ReadLine();

            if (String.Equals(decisao, "s"))
            {
                Console.WriteLine("Digite o saldo a ser depositado");
                saldo = double.Parse(Console.ReadLine());
                c.Deposito(saldo);
            }

            Console.WriteLine(c);

            Console.WriteLine("Digite o saldo a ser depositado");
            saldo = double.Parse(Console.ReadLine());
            c.Deposito(saldo);

            Console.WriteLine(c);

            Console.WriteLine("Digite o saque a ser retirado");
            saque = double.Parse(Console.ReadLine());
            c.Saque(saque);

            Console.WriteLine(c);
        
        }
    }
}
