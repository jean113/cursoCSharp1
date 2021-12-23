using System;

namespace cap4
{
    class Program
    {
        static void Main(string[] args)
        {
            Pessoa p1, p2;

            p1 = new Pessoa();
            p2 = new Pessoa();

            Console.WriteLine("Entre com o nome da Pessoa 1");
            p1.Nome = Console.ReadLine();
            Console.WriteLine("Entre com a idade da Pessoa 1");
            p1.Idade = Int32.Parse(Console.ReadLine());

            Console.WriteLine("Entre com o nome da Pessoa 2");
            p2.Nome = Console.ReadLine();
            Console.WriteLine("Entre com a idade da Pessoa 2");
            p2.Idade = Int32.Parse(Console.ReadLine());

            if (p1.Idade > p2.Idade )
                Console.WriteLine(p1.Nome + " é mais velho");
            else if (p1.Idade < p2.Idade )
                Console.WriteLine(p2.Nome + " é mais velho");
        }
    }
}
