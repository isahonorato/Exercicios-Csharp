using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bee1046
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int inicial, final, horas = 24, resultado;
            Console.WriteLine("Tempo de Jogo");
            Console.WriteLine("====================");
            Console.WriteLine("Insira a hora inicial do jogo:");
            inicial = int.Parse(Console.ReadLine());
            Console.WriteLine("Insira a hora final do jogo:");
            final = int.Parse(Console.ReadLine());

            if(inicial > final)
            {
                resultado = horas - inicial + final;
                Console.WriteLine("O jogo durou " + resultado + " horas");
            }
            else if (inicial < final)
            {
                resultado = final - horas + horas - inicial;
                Console.WriteLine("O jogo durou " + resultado + " horas");
            }
            else if (inicial == 0 && final == 0)
            {
                Console.WriteLine("DIGITE VALORES VÁLIDOS!");
            }
            Console.ReadKey();
        }

    }
}
