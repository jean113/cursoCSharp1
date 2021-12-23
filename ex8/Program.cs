using System;
using System.Globalization;

namespace ex8
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Entre com os dados do ciente");

            Console.Write("Nome: ");
            string nome = Console.ReadLine();
            Console.Write("Email: ");
            string email = Console.ReadLine();
            Console.Write("Dt de Nascimento: ");
            DateTime nascimento = DateTime.Parse(Console.ReadLine());

            Client cliente = new Client(nome, email, nascimento);

            Console.WriteLine("Digite o status da Ordem");
            OrderStatus status = Enum.Parse<OrderStatus>(Console.ReadLine());

            Order ordem = new Order(DateTime.Now, status, cliente);

            Console.WriteLine("");

            Console.WriteLine("Quantos itens para esta ordem?");
            int qtd = int.Parse(Console.ReadLine());

            Console.WriteLine("");

            for(int i=0; i < qtd; i++)
            {
                Console.WriteLine($"Entre com os dados do produto #{(i + 1)}");

                Console.Write("Nome do produto: ");
                string nome_produto = Console.ReadLine();
                Console.Write("Preço: ");
                double preco = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                Console.Write("Quantidade: ");
                int qtd_produto = int.Parse(Console.ReadLine());

                Product p = new Product(nome_produto, preco);

                OrderItem item = new OrderItem(qtd_produto, preco, p);

                ordem.addItem(item);
                
            }

            Console.WriteLine("");

            Console.WriteLine("ORDER SUMMARY:");
            Console.WriteLine(ordem);
        }
    }
}
