using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimularConversa
{
    class Program
    {
        static void Main(string[] args)
        {
            string nome,cidade;
            int anos;
            Console.WriteLine("Olá eu sou uma máquina...");
            Console.WriteLine("Qual é o seu nome? ");
            nome = Console.ReadLine();
            Console.WriteLine("Oi "+nome+" Quantos anos você tem? ");
            anos = int.Parse(Console.ReadLine());
            Console.WriteLine(nome+" você tem "+anos+" !!em que cidade você mora? ");
            cidade = Console.ReadLine();
            Console.WriteLine("Bem-Vindo a Matrix "+nome+" da cidade de "+cidade);
            Console.ReadKey();
        }
    }
}
