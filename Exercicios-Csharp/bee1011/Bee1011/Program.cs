﻿using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bee1011
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double raio, volume;

            Console.WriteLine("Calcule o volume de uma esfera:");
            Console.WriteLine("Insira o valor do raio:");

            raio = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            volume = 4.0 / 3.0 * 3.14159 * raio * raio * raio;

            Console.WriteLine("O volume da esfera é: " + volume.ToString("F3", CultureInfo.InvariantCulture));
            Console.ReadKey();
        }
    }
}
