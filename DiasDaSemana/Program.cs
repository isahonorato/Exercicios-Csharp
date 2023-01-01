using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dia_da_Semana
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Olá! Insira em qual dia da semana você está em NÚMEROS:");
            int valor = int.Parse(Console.ReadLine());
            string dia;

            switch (valor)
            {
                case 1:
                    dia = "Domingo";
                    break;
                case 2:
                    dia = "Segunda";
                    break;
                case 3:
                    dia = "Terça";
                    break;
                case 4:
                    dia = "Quarta";
                    break;
                case 5:
                    dia = "Quinta";
                    break;
                case 6:
                    dia = "Sexta";
                    break;
                case 7:
                    dia = "Sábado";
                    break;
                default:
                    dia = "Valor inválido!";
                    break;
            }
            Console.Clear();
            Console.WriteLine("Agora digite o mês em que você está:");
            string mes = Console.ReadLine();
            Console.WriteLine("O dia da semana em que você está hoje é: " + dia + ", no mês de " + mes);
            Console.ReadKey();
        }
    }
}
