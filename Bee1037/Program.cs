using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bee1037
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double valorEntrada;

            Console.WriteLine("Leitura de valores - Bee1037");
            Console.WriteLine();
            Console.WriteLine("Digite um valor qualquer para saber em qual intervalo ele se encaixa:");

            valorEntrada = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            if (valorEntrada <=25.0)
            {
                Console.WriteLine("\t\r\nIntervalo [0,25]");
            }
            else if (valorEntrada <=50.0)
            {
                Console.WriteLine("\t\r\nIntervalo [25,50]");
            }
            else if ( valorEntrada <= 75.0)
            {
                Console.WriteLine("\t\r\nIntervalo [50,75]");
            }
            else if (valorEntrada < 0.0 || valorEntrada > 100.0)
            {
                Console.WriteLine("Fora de intervalo");
            }
            else
            {
                Console.WriteLine("\t\r\nIntervalo [75,100]");
            }
            Console.ReadKey();
        }
    }
}
