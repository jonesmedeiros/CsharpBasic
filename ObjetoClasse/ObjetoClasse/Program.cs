using System.Reflection.PortableExecutable;

namespace ObjetoClasse
{
    internal class Program {
        static void Main(string[] args) {
           Pessoa p1 = new Pessoa();
           Triangulo t1 = new Triangulo();
            

           Console.WriteLine("Digite a sua idade: "); 
           p1.Idade = int.Parse(Console.ReadLine());
           
           Console.WriteLine("Digite o seu nome: ");
           p1.Nome = Console.ReadLine();
           
           Console.WriteLine($" O seu nome é {p1.Nome} e sua idade é {p1.Idade}. "); 

           Console.WriteLine("Digite o lado A do triangulo em que deseja encontrar a area: ");
           t1.LadoA = double.Parse(Console.ReadLine());
           Console.WriteLine("Digite o lado B do triangulo em que deseja encontrar a area: ");
           t1.LadoB = double.Parse(Console.ReadLine());
           Console.WriteLine("Digite o lado C do triangulo em que deseja encontrar a area: ");
           t1.LadoC = double.Parse(Console.ReadLine());

           double Area = t1.AreaTri();

            Console.WriteLine($" Os lados A {t1.LadoA}, B {t1.LadoB} e C {t1.LadoC} tem uma area total de {Area:F2} M² ");
        }
    }
}