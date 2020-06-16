using System;

namespace Restaurante
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("---------------------");
            Console.WriteLine("-----Restaurante-----");
            Console.WriteLine("---------------------");
            Console.WriteLine("");
            Console.WriteLine("peso médio do prato 148g");
            Console.WriteLine("preço por quilo 14,00");
            Console.WriteLine("----------------------------------------");
            Console.Write("digite quantas gramas o seu prato pesou:");
            decimal peso = decimal.Parse(Console.ReadLine());
            decimal pagar = (peso / 1000) * 14;
            Console.WriteLine("----------------------------------------");
            Console.WriteLine(peso + " gramas custa R$" + pagar(3,1);
        }
    }
}
