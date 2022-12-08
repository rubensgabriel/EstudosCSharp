using System;

namespace meuPrimeirPrograma
{
    class Program
    {
        static void Main(string[] args)
        {
            int idade;
            int maior = 0;
            int cont5 = 0;
            int cont18 = 0;
            double media = 0.0;

            for(int i = 0; i < 10; i++)
            {
                Console.WriteLine("Informe a idade da " + (i+1) + "º pessoa: ");
                idade = Convert.ToInt32(Console.ReadLine());
                media += idade;
                if(idade > maior)
                {
                    maior = idade;
                }
                if(idade > 18)
                {
                    cont18 += 1;
                }
                if(idade < 5)
                {
                    cont5 += 1;
                }
            }
            Console.Clear();

            media = media/10;
            Console.WriteLine("==================================================");
            Console.WriteLine("== Relatório de acordo com as idades informadas ==");
            Console.WriteLine("==================================================");
            Console.WriteLine("Média de idade do grupo de pessoas: " + media);
            Console.WriteLine("Pessoas com mais de 18 anos: " + cont18);
            Console.WriteLine("Pessoas com menos de 5 anos: " + cont5);
            Console.WriteLine("Maior idade informada: " + maior);
        }
    }
}