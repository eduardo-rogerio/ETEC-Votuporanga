using System;

namespace terrenosRetangulares
{
    class Program
    {
        static void Main(string[] args)
        {
            float largura, comprimento;
            Console.WriteLine("Digite a largura do terreno:");
            largura = float.Parse(Console.ReadLine());
            Console.WriteLine("Digite a comprimento do terreno:");
            comprimento = float.Parse(Console.ReadLine());

            Console.WriteLine("A área do terreno é = " + largura * comprimento+".");
        }
    }
}
