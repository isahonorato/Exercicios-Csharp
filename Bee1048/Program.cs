using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace Bee1048
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string nomeFuncionario;
            double salarioAtual, percentual, salarioNovo, reajuste;

            Console.WriteLine("***Aumento de salário - 2023***");
            Console.WriteLine();
            Console.WriteLine("Para começarmos, insira o seu nome:");
            nomeFuncionario = Console.ReadLine();
            Console.WriteLine("Insira o seu salário atual, sem descontos:");
            salarioAtual = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            if (salarioAtual <= 400.0)
            {
                percentual = 15.0;
            }
            else if (salarioAtual <= 800.0)
            {
                percentual = 12.0;
            }
            else if (salarioAtual <= 1200.0)
            {
                percentual = 10.0;
            }
            else if (salarioAtual <= 2000.0)
            {
                percentual = 7.0;
            }
            else
            {
                percentual = 4.0;
            }

            reajuste = percentual * salarioAtual /100.0;
            salarioNovo = salarioAtual + reajuste;

            Console.WriteLine(nomeFuncionario + " o seu novo salário é de " + salarioNovo+ " o reajuste foi de " + percentual + "%");
            Console.ReadKey();
        }
    }
}
