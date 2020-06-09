using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Metadata.W3cXsd2001;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Inverte3numeros
{
    class Program
    {
        static void Main(string[] args)
        {
            string n1, n2, n3;
            Console.WriteLine("Digite o primeiro numero:");
            n1 = Console.ReadLine();
            Console.WriteLine("Digite o segundo numero:");
            n2 = Console.ReadLine();
            Console.WriteLine("Digite o terceiro numero:");
            n3 = Console.ReadLine();
            Console.WriteLine("Os numeros digitados na ordem invertida: " + n3 +", " + n2 + ", " + n1);
            Console.ReadKey();
            
        }
    }
}
