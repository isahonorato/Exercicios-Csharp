using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Globalization;

namespace Bee1008
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numFuncionario;
            double salario, valorHora, horasTrabalhadas;
            
            Console.WriteLine("***CÁLCULO DE SALÁRIO COM BASE NAS HORAS TRABALHAS***");
            Console.WriteLine("Digite o número do Funcionário:");
            numFuncionario = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite o valor que o funcionário recebe por hora:");
            valorHora = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.WriteLine("Digite as horas que o funcionário trabalhou até o momento:");
            horasTrabalhadas = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            salario = valorHora * horasTrabalhadas;

            Console.WriteLine("O salário do funcionário de ID " + numFuncionario + " é de R$ " + salario);

            Console.ReadLine();
            Console.ReadKey();

        }
    }
}
