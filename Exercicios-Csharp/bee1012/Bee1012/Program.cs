using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bee1012
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double A, B, C, areaTriangulo, areaTrapezio, areaCirculo, areaQuadrado, areaRetangulo;

            Console.WriteLine("***Leitura de valores com ponto flutuante de dupla precisão***");
            Console.WriteLine("");
            Console.WriteLine("Insira os valores - TRIANGULO, CIRCULO, TRAPEZIO, QUADRADO e RETANGULO:");
            string[] valores = Console.ReadLine().Split(' ');
            A = double.Parse(valores[0], CultureInfo.InvariantCulture);
            B = double.Parse(valores[1], CultureInfo.InvariantCulture);
            C = double.Parse(valores[2], CultureInfo.InvariantCulture);

            areaTriangulo = A * C / 2.00;
            areaCirculo = 3.14159 * C * C;
            areaTrapezio = (A + B) / 2.0 * C;
            areaQuadrado = B * B;
            areaRetangulo = A * B;

            Console.WriteLine("O valor do TRIANGULO é: " + areaTriangulo.ToString("F3", CultureInfo.InvariantCulture));
            Console.WriteLine("O valor do CIRCULO é: " + areaCirculo.ToString("F3", CultureInfo.InvariantCulture));
            Console.WriteLine("O valor do TRAPEZIO é: " + areaTrapezio.ToString("F3", CultureInfo.InvariantCulture));
            Console.WriteLine("O valor do QUADRADO é: " + areaQuadrado.ToString("F3", CultureInfo.InvariantCulture));
            Console.WriteLine("O valor do RETANGULO é: " + areaRetangulo.ToString("F3", CultureInfo.InvariantCulture));
            Console.ReadKey();
        }
    }
}
