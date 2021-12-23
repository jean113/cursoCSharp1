using System;

namespace ex2
{
    class Program
    {
        static void Main(string[] args)
        {
            Funcionario p1, p2;

            double media;

            p1 = new Funcionario();
            p2 = new Funcionario();

            Console.WriteLine("Entre com o nome do funcionario 1");
            p1.Nome = Console.ReadLine();
            Console.WriteLine("Entre com o salario do funcionario 1");
            p1.Salario = double.Parse(Console.ReadLine());

            Console.WriteLine("Entre com o nome do funcionario 2");
            p2.Nome = Console.ReadLine();
            Console.WriteLine("Entre com o salario do funcionario 2");
            p2.Salario = double.Parse(Console.ReadLine());

            media = (p1.Salario + p2.Salario) / 2; 

            Console.WriteLine("A média do salario é: " + media );

        }
    }
}
