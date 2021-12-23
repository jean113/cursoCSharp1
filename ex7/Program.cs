using System;
using System.Collections.Generic;

namespace ex7
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Empregado> lista = new List<Empregado>();
            Empregado e;
            double porc;
            int qtd_empregados, id;

            Console.WriteLine("Digite a quantidade de empregados");
            qtd_empregados = int.Parse(Console.ReadLine());

            for( int i=0; i < qtd_empregados; i++ )
            {
                e = new Empregado();
                Console.WriteLine("Digite o id do empregado");
                e.Id = int.Parse(Console.ReadLine());

                Console.WriteLine("Digite o nome do empregado");
                e.Nome = Console.ReadLine();

                Console.WriteLine("Digite o salário do empregado");
                e.Salario = double.Parse(Console.ReadLine());

                lista.Add(e);
            }

            Console.WriteLine("Digite o id do empregado que terá aumento de salário");
            id = int.Parse(Console.ReadLine());

        
            e = lista.Find( x => x.Id == id /* -> expressão lambda*/ );

            if (e != null)
            {
                Console.WriteLine("Digite o aumento do salário do empregado em porcentagem");
                porc = double.Parse(Console.ReadLine());
                e.IncrementarSalario(porc);     
            }
            else  
                Console.WriteLine("Este id não existe!!!!"); 

            Console.WriteLine("");
            Console.WriteLine("=============================");
            Console.WriteLine("");
            
            Console.WriteLine("Lista atualizada de empregados");
            foreach(Empregado obj in lista)
            {
                Console.WriteLine(obj);    
            }

        }
    }
}
