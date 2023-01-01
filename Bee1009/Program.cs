using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bee1009
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string vendedor;
            double salarioFixo, totalVendas,salarioFinal;

            Console.WriteLine("CÁLCULO DE COMISSÃO MENSAL - VENDEDORES");
            Console.WriteLine("Insira o nome do vendedor");
            vendedor = Console.ReadLine();
            Console.WriteLine("Insira o salário padrão do vendedor:");
            salarioFixo = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.WriteLine("Insira o valor total de vendas feitas no mês:");
            totalVendas = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture) ;

            salarioFinal = totalVendas * 15.0 / 100 + salarioFixo;

            Console.WriteLine("O salário final do vendedor " + vendedor +  " é de R$" + salarioFinal.ToString("F2", CultureInfo.InvariantCulture));

            Console.ReadLine();
            Console.ReadKey();
            
        }
    }
}
