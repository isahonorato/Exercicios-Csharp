
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bee1019
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int N, horas, resto, minutos, segundos;

            Console.WriteLine("Conversão de tempo - Horas, minutos e segundos");
            Console.WriteLine("Insira abaixo o total de horas que seja converter:");

            N = int.Parse(Console.ReadLine());

            horas = N / 3600;
            resto= N % 3600;
            minutos = resto / 60;
            segundos = resto % 60;

            Console.WriteLine("Temos um total de: " + horas + "h:" + minutos + "m:" + segundos + "s");
            Console.ReadKey();

        }
    }
}
