using System;
using System.Collections.Generic;

namespace ex2
{
    class Program
    {
        static void Main(string[] args)
        {
            HashSet<int> alunos = new HashSet<int>();
            int qtd_alunos, cod_aluno;


            Console.Write("How Many Students for the Course A? "); 
            qtd_alunos = int.Parse(Console.ReadLine());

            for(int i=0 ; i< qtd_alunos; i++)
            {
                alunos.Add(int.Parse(Console.ReadLine()));
            }

            Console.Write("How Many Students for the Course B? "); 
            qtd_alunos = int.Parse(Console.ReadLine());

            for(int i=0 ; i< qtd_alunos; i++)
            {
                alunos.Add(int.Parse(Console.ReadLine()));
            }

            Console.Write("How Many Students for the Course C? "); 
            qtd_alunos = int.Parse(Console.ReadLine());

            for(int i=0 ; i< qtd_alunos; i++)
            {
                alunos.Add(int.Parse(Console.ReadLine()));
            }

            Console.WriteLine("Total: " + alunos.Count);
        }
    }
}
