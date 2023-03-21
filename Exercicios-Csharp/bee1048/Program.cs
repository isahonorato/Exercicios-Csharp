using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace Bee1048_AumentoSalario
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double salarioInicial, salarioFinal;
            string nomeFuncionario;

            Console.WriteLine("---- Empresa ABC ----");
            Console.WriteLine();
            Console.WriteLine("Saiba o seu ajuste do seu salário esse ano, insira o seu nome abaixo:");
            nomeFuncionario = Console.ReadLine();
            Console.WriteLine("Insira o seu salário atual:");
            salarioInicial = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            if (salarioInicial <= 400)
            {
                salarioFinal = salarioInicial + 15.0;
            }
            else if (salarioInicial <= 800)
            {
                salarioFinal = salarioInicial + 12.0;
            }
            else if (salarioInicial <= 1.200)
            {
                salarioFinal = salarioInicial + 10.0;
            }
            else if (salarioInicial <= 2.000)
            {
                salarioFinal = salarioInicial + 7.0;
            }
            else if (salarioInicial >= 2.000)
            {
                salarioFinal = salarioInicial + 4.0;
            }
            else if(salarioInicial <= 0)
            {
                Console.WriteLine("INVÁLIDO");
            }


            Console.ReadKey();
        }
    }
}
