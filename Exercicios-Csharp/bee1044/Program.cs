using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bee1044
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] vet = Console.ReadLine().Split();
            int a, b;
            a = int.Parse(vet[0]);
            b = int.Parse(vet[1]);

            a = a % 2;
            b = b % 2;

            if (a == 0 && b == 0)
            {
                Console.WriteLine("São múltiplos");
            }
            else
            {
                Console.WriteLine("Não são múltiplos");
            }
        }
    }
}
