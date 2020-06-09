using System;

namespace lojaDeRoupas
{
    class Program
    {
        static void Main(string[] args)
        {
            int P, M, G;
            int total;
            
            Console.Write("Digite quantas blusas pequenas você comprou:");
            P = int.Parse(Console.ReadLine());
            Console.Write("Digite quantas blusas médias você comprou:");
            M = int.Parse(Console.ReadLine());
            Console.Write("Digite quantas blusas grandes você comprou:");
            G = int.Parse(Console.ReadLine());

            total = (P * 15) + (M*18) + (G*20);
            Console.WriteLine("O total a pagar é R$"+total+".");
        }
    }
}
