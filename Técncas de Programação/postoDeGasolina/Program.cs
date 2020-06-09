using System;

namespace posto_de_gasolina
{
    class Program
    {
        static void Main(string[] args)
        { double qt_litros;
            int valor;
            double gasolina = 3.45;
            Console.WriteLine("---------------GASOLINA R$ 3,45---------------");

            Console.WriteLine("Digite quanto deseja abastecer:");
            valor = int.Parse(Console.ReadLine());

            qt_litros = valor / gasolina;
            
            Console.WriteLine("O preço do combustivel é R$ 3,45");
            Console.WriteLine("Você abasteceu " + qt_litros+" litros");
            Console.WriteLine("-----------------------------------------------");
            Console.ReadKey();

        }
    }
}
