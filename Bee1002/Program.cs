using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bee1002
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double area, raio;
            double n = 3.14159;
            
            Console.WriteLine("Digite o valor do raio");
            raio = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            area = Math.Pow(raio, 2) * n;

            Console.WriteLine("A área do círculo é de " + area);

            Console.ReadKey();
            Console.ReadLine();
        }
    }
}
