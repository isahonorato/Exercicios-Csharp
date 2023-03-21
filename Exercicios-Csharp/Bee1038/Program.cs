using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bee1038
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int codigo, quantidade;
            double valor =0, soma;
            string nome;

            Console.WriteLine("***Barraca de Lanches***");
            Console.WriteLine();
            Console.WriteLine("Olá! Me chamo Isabella e irei atender você. Para começarmos, me conta o seu nome?");
            nome = Console.ReadLine();
            Console.Clear();
            Console.WriteLine("Ótimo " + nome + ", vou te mostrar o nosso cardápio:");
            Console.WriteLine();
            Console.WriteLine("1 - Cachorro Quente - R$ 4,00");
            Console.WriteLine("2 - X-Salada - R$ 4,50");
            Console.WriteLine("3 - X-Bacon - R$ 5,00");
            Console.WriteLine("4 - Torrada simples - R$ 2,00");
            Console.WriteLine("5 - Refrigerante - r$ 1,50");
            Console.WriteLine();
            Console.WriteLine("Coloque o número do item que deseja");
            codigo = int.Parse(Console.ReadLine());
            Console.WriteLine("Coloque a quantidade do item que deseja");
            quantidade = int.Parse(Console.ReadLine());

            if (codigo == 1)
            {
                valor = 4.00;
            }
            else if (codigo == 2)
            {
                valor = 4.50;
            }
            else if (codigo == 3)
            {
                valor = 5.00;
            }
            else if (codigo == 4)
            {
                valor = 2.00;

            }
            else if (codigo == 5)
            {
                valor =1.50;
            }
            else
            {
                string mensagem = "Digite um valor válido!";
            }

            soma = (valor * quantidade);

            Console.WriteLine("Total a pagar R$" + soma.ToString("F2"));

            Console.ReadKey();
        }
    }
}
