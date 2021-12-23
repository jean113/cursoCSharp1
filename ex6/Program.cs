using System;

namespace ex6
{
    class Program
    {
        static void Main(string[] args)
        {
            Estudante[] pensao = new Estudante[10];
            string nome, email;
            int qtd_quartos_alugados, qtd_escolhido;

            Console.WriteLine("Digite a qtd de alunos que vão ficar na pensão");
            qtd_quartos_alugados = int.Parse(Console.ReadLine());

            for(int i = 0; i < qtd_quartos_alugados ; i++ )
            {
                Console.WriteLine("Digite o nome do aluno");
                nome = Console.ReadLine(); 

                Console.WriteLine("Digite o email do aluno");
                email = Console.ReadLine();                

                Console.WriteLine("Digite o quarto que o aluno escolheu");
                qtd_escolhido = int.Parse(Console.ReadLine());

                pensao[qtd_escolhido] = new Estudante {Nome = nome, Email = email };
            }

            Console.WriteLine("Quartos ocupados");

            for(int i = 0; i < 10 ; i++ )
            {
                if(pensao[i] != null)
                    Console.WriteLine( i +": " +pensao[i]);
            }
            
        }
    }
}
