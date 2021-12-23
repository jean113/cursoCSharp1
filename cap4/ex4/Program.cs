using System;

namespace ex4
{
    class Program
    {
        static void Main(string[] args)
        {
            Funcionario f;
            double porcentagem;

            f = new Funcionario();

            Console.WriteLine("Digite o nome do funcionario");
            f.Nome = Console.ReadLine();

            Console.WriteLine("Digite o salário do funcionario");
            f.SalarioBruto = double.Parse(Console.ReadLine());

            Console.WriteLine("Digite o imposto");
            f.Imposto = double.Parse(Console.ReadLine());

            Console.WriteLine("Funcionario: " + f);


            Console.WriteLine("Digite o aumento de Salario");
            porcentagem = double.Parse(Console.ReadLine());

            f.AumentaSalario(porcentagem);

            Console.WriteLine("Funcionario: " + f);



        }
    }
}
