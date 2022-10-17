using System;
using System.Globalization;

namespace Estoque{
    internal class Program{
        static void Main(string[] args)
        {
            Produto p1 = new Produto();
            
            Console.WriteLine("Entre com os dados do produto:");
            Console.WriteLine("Digite o nome do produto");
            p1.Nome = Console.ReadLine();
            Console.WriteLine("Digite o preço do produto");
            p1.Preco = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture );
            Console.WriteLine("Digite a quantidade do produto");
            p1.Quantidade = int.Parse(Console.ReadLine());   

            Console.WriteLine($"Dados do produto: {p1}"); 

            Console.WriteLine();
            Console.WriteLine("Digite o numero de produtos que serão adicionados: ");
            int qte = int.Parse(Console.ReadLine());
            p1.AdicionarProdutos(qte);

            Console.WriteLine("Dados atualizados: " + p1);

            Console.WriteLine();
            Console.WriteLine("Digite o numero de produtos que serão removidos: ");
            qte = int.Parse(Console.ReadLine());
            p1.RemoverProdutos(qte);

            Console.WriteLine("Dados atualizados: " + p1);

        }
    }
}
