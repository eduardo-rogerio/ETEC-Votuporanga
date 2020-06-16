using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Salario
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("digite quantas horas trabalhou esse mês: ");
            int hora = int.Parse(Console.ReadLine());
            Console.Write("digite quantas horas extra fez esse mês: ");
            int horaEx = int.Parse(Console.ReadLine());
            decimal salarioB = (hora * 20) + (horaEx * 30);
            decimal salarioL = (salarioB * 10) / 100;
            Console.WriteLine("seu salário bruto esse mês é " + salarioB(5,2));
            Console.WriteLine("seu salário liquido esse mês é " + salarioL(5,2));
        }
    }
}
