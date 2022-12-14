using System;
using System.Globalization;

namespace ConsoleApplication2 {

    class Program {

        static void Main(String[] args) {
            string produto1 = "Computador";
            string produto2 = "Mesa de escritorio";

            byte idade = 35;
            int codigo = 5290;
            char genero = 'M';

            double preco1 = 2100.0;
            double preco2 = 650.50;
            double medida = 53.234567;

            Console.WriteLine("Produtos:");
            Console.WriteLine($"{produto1}, cujo o preço é $ {preco1} ");
            Console.WriteLine($"{produto2}, cujo o preço é $ {preco2} ");
            Console.WriteLine($"Registro: {idade} anos de idade, codigo {codigo} e genero {genero}");
            Console.WriteLine($"Medida com oito casa decimais: {medida:F8}");
            Console.WriteLine($"Arredondando (tres casa decimais) {medida:F3}");
            Console.WriteLine("Separador decimal variant culture: " + medida.ToString("F2", CultureInfo.InvariantCulture));
        }
    }

}