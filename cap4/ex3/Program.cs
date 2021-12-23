using System;

namespace ex3
{
    class Program
    {
        static void Main(string[] args)
        {
            Aluno a;

            a = new Aluno();

            Console.WriteLine("Digite o nome do aluno");
            a.Nome = Console.ReadLine();

            Console.WriteLine("Entre com as notas do aluno");
            a.N1 = double.Parse(Console.ReadLine());
            a.N2 = double.Parse(Console.ReadLine());
            a.N3 = double.Parse(Console.ReadLine());

            a.resultado();
        }
    }
}
