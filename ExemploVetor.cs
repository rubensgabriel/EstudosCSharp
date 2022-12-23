using System;

namespace meuPrimeirPrograma
{
    class Program
    {
        static void Main(string[] args)
        {
            // Exemplo de Vetores
            int cont;

            Console.WriteLine("Informe o tamanho do vetor: ");
            cont = Convert.ToInt32(Console.ReadLine());

            int[] idades = new int[cont];
            
            for(int i = 0; i < cont; i++)
            {
                Console.WriteLine("Informe a " + (i+1) + "º idade:");
                idades[i] = Convert.ToInt32(Console.ReadLine());
            }
            for(int i = 0; i < cont; i++)
            {
                Console.WriteLine("idades [" + i + "] = " + idades[i]);
            }
        }
    }
}
