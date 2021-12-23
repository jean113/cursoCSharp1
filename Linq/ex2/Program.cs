using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;

namespace ex2
{
    class Program
    {
        static void Main(string[] args)
        {
            double valor;
            List<Employee> lista = new List<Employee>();

            lista.Add(new Employee() {Name = "Maria", Email = "maria@gmail.com", Salary = 3200.00  }  );
            lista.Add(new Employee() {Name = "Alex", Email = "alex@gmail.com", Salary = 1900.00  }  );
            lista.Add(new Employee() {Name = "Marco", Email = "marco@gmail.com", Salary = 1700.00  }  );
            lista.Add(new Employee() {Name = "Bob", Email = "bob@gmail.com", Salary = 3500.00  }  );
            lista.Add(new Employee() {Name = "Anna", Email = "anna@gmail.com", Salary = 2800.00  }  );

            Console.Write("Digite um salario: ");
            valor = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            /*select Email from Lista de Funcionarios Where Salary > ? Order By Email*/
            var resultado = lista.Where( f => f.Salary > valor  ).OrderBy(f => f.Email).Select( f => f.Email);

            foreach(string email in resultado)
                Console.WriteLine(email);

            /*select Sum(Salary) from Lista de Funcionarios Where Name like 'M%'*/
            var soma_salario = lista.Where( f => f.Name[0] == 'M' ).Sum(f => f.Salary);

            Console.WriteLine("Somna dos salários que começam por M: " + soma_salario);
        }
    }
}
