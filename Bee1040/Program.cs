using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bee1040
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double nota1, nota2, nota3, nota4, notaExame, somaMedia, mediaFinal;
            string nomeAluno, bimestreOuSemestre, disciplina;
            DateTime dataAgora = DateTime.Now;

            Console.WriteLine("***Calculadora de média***");
            Console.WriteLine();

            Console.WriteLine("Insira o nome do aluno:");
            nomeAluno= Console.ReadLine();

            Console.WriteLine("Qual o bimestre ou semestre?");
            bimestreOuSemestre= Console.ReadLine();

            Console.WriteLine("Qual a disciplina?");
            disciplina = Console.ReadLine();

            Console.WriteLine("Insira a primeira nota:");
            
            nota1 = double.Parse(Console.ReadLine());

            Console.WriteLine("Insira a segunda nota:");
            nota2 = double.Parse(Console.ReadLine());

            Console.WriteLine("Insira a terceira nota:");
            nota3= double.Parse(Console.ReadLine());

            Console.WriteLine("Insira a quarta nota");
            nota4 = double.Parse(Console.ReadLine());
            Console.WriteLine();

            somaMedia = nota1 + nota2 + nota3 + nota4;

            mediaFinal = somaMedia / 4;

            if( mediaFinal >= 7.0){
                Console.WriteLine("ALUNO: " + nomeAluno);
                Console.WriteLine("APROVADO no " + bimestreOuSemestre + " na data: " + dataAgora);
                Console.WriteLine("Matéria: " + disciplina);
            }
            else if(mediaFinal >= 5.0 && mediaFinal <= 6.9)
            {
                Console.WriteLine("ALUNO EM EXAME");
                Console.WriteLine("Digite a nota do exame:");
                notaExame = double.Parse(Console.ReadLine());
                Console.WriteLine();
                Console.WriteLine("A nota do exame é:  " + notaExame);
                Console.WriteLine();
                if (mediaFinal + notaExame / 2 >= 5.0)
                {
                    Console.WriteLine("ALUNO: " + nomeAluno);
                    Console.WriteLine("APROVADO VIA EXAME ADICIONAL no " + bimestreOuSemestre + " na data: " + dataAgora);
                    Console.WriteLine("Matéria: " + disciplina);
                }

                else
                {
                    Console.WriteLine("ALUNO: " + nomeAluno);
                    Console.WriteLine("REPROVADO no " + bimestreOuSemestre + " na data: " + dataAgora);
                    Console.WriteLine("Matéria: " + disciplina);
                }
            }
            else
            {
                Console.WriteLine("ALUNO: " + nomeAluno);
                Console.WriteLine("REPROVADO no " + bimestreOuSemestre + " na data: " + dataAgora);
                Console.WriteLine("Matéria: " + disciplina);
            }
            Console.ReadKey();
        }
    }
}
