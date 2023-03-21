using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bee1020
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int idade, anos, meses, dias, resto;

            Console.WriteLine("CALCULE A SUA IDADE EM ANOS, MESES E DIAS");
            Console.WriteLine("Insira a sua idade:");
            idade = int.Parse(Console.ReadLine());

            anos = idade / 365;
            resto = idade % 365;
            meses = resto / 30;
            dias = resto % 30;

            Console.WriteLine();
            Console.WriteLine("Você tem " + anos + " ano(s)");
            Console.WriteLine("Você tem " + meses + " mes(es)");
            Console.WriteLine("Você tem " + dias + " dia(s)");

            Console.ReadKey();
        }
    }
}
