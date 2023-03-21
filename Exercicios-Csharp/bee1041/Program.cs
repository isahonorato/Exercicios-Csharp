using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bee1041
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double numero1, numero2;

            Console.WriteLine("Digite o primeiro valor:");
            numero1 = double.Parse(Console.ReadLine());
            numero2= double.Parse(Console.ReadLine());

            if (numero1 == 0.0 && numero2 == 0.0)
            {
                Console.WriteLine("Origem");
            }
            else if (numero1 == 0.0)
            {
                Console.WriteLine("Eixo Y");
            }
            else if (numero2 == 0.0)
            {
                Console.WriteLine("Eixo X");
            }
            else if (numero1 > 0.0 && numero2 > 0.0)
            {
                Console.WriteLine("Q1");
            }
            else if (numero1 < 0.0 && numero2 > 0.0)
            {
                Console.WriteLine("Q2");
            }
            else if (numero1 < 0.0 && numero2 < 0.0)
            {
                Console.WriteLine("Q3");
            }
            else
            {
                Console.WriteLine("Q4");
            }
            Console.ReadKey();

        }
    }
}
