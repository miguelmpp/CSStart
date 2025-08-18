using System;

namespace MyApp
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int idade1, idade2;


            Console.WriteLine("Insira a idade do primeiro aluno:");
            idade1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Insira a idade do segundo aluno:");
            idade2 = int.Parse(Console.ReadLine());


            if (idade1 > idade2)
            {
                Console.WriteLine("O primeiro aluno e o mais velho e o segundo aluno e o mais novo.");
            }
            else if (idade2 > idade1)
            {
                Console.WriteLine("O segundo aluno e o mais velho e o primeiro aluno e o mais novo.");
            }
            else if (idade1 == idade2)
            {
                Console.WriteLine("Ambos os alunos tem a mesma idade.");
            }
        }
    }
}