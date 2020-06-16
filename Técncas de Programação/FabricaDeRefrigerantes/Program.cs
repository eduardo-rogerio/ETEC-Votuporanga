using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FabricaDeRefrigerantes
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Digite quantas latas você comprou:");
            double lata = double.Parse(Console.ReadLine());
            Console.Write("Digite quantas garrafas de 600ml você comprou:");
            double garrafaP = double.Parse(Console.ReadLine());
            Console.Write("Digite quantas garragas de 2L você comprou:");
            double garrafaG = double.Parse(Console.ReadLine());
            double resultado = (lata * 350 + garrafaP * 600 + garrafaG * 2000)/1000;
            Console.Write("A quantidade de Litros de refrigerante comprado foi: " + resultado+"L");
            Console.ReadKey();

        }
    }
}
