using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bee1018
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int N, quociente, resto, nota;


            Console.WriteLine("***CAIXA ELETRÔNICO***");
            Console.WriteLine("Insira o valor que deseja sacar:");
            N = int.Parse(Console.ReadLine());
            Console.WriteLine();
            resto = N;

            nota = 100;
            quociente = resto / nota;
            Console.WriteLine("CÉDULAS DISPONÍVEIS PARA O SAQUE: ");
            Console.WriteLine( quociente + " nota(s) de R$ " + nota + ",00");
            resto = resto % nota;

            nota = 50;
            quociente = resto / nota;
            Console.WriteLine(quociente + " nota(s) de R$ " + nota + ",00");
            resto = resto % nota;

            nota = 20;
            quociente = resto / nota;
            Console.WriteLine(quociente + " nota(s) de R$ " + nota + ",00");
            resto = resto % nota;

            nota = 10;
            quociente = resto / nota;
            Console.WriteLine(quociente + " nota(s) de R$ " + nota + ",00");
            resto = resto % nota;

            nota = 5;
            quociente = resto / nota;
            Console.WriteLine(quociente + " nota(s) de R$ " + nota + ",00");
            resto = resto % nota;

            nota = 2;
            quociente = resto / nota;
            Console.WriteLine(quociente + " nota(s) de R$ " + nota + ",00");
            resto = resto % nota;

            Console.WriteLine(resto + " nota(s) de R$ 1,00");

            Console.ReadLine();
            Console.ReadKey();
        }
    }
}
