using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bee1035
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int A, B, C, D;
            Console.WriteLine("Seja bem vindo (a) ao Teste de Seleção 1");
            Console.WriteLine("Digite o primeiro número inteiro:");
            A = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite o segundo número inteiro:");
            B = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite o terceiro número inteiro:");
            C = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite o quarto número inteiro:");
            D = int.Parse(Console.ReadLine());

            if  ((B > C) && (D > A) && (C + D) > (A + B) && (C > 0) && (D > 0) && (A % 2) == 0)
            {
                Console.WriteLine("Valores aceitos!");
            }
            else
            {
                Console.WriteLine("Valores inválidos!!!");
            }
            Console.ReadKey();
        }
    }

}

