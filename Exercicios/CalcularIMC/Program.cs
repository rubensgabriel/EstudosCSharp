using System;

namespace meuPrimeirPrograma
{
    class Program
    {
        static void Main(string[] args)
        {
            double altura;
            double peso;

            Console.WriteLine("================================");
            Console.WriteLine("= Calcular o IMC de uma pessoa =");
            Console.WriteLine("================================");

            Console.WriteLine("Informe a altura: ");
            altura = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Informe o peso: ");
            peso = Convert.ToDouble(Console.ReadLine());

            double imc = peso / (altura * altura);

            Console.Clear();

            Console.WriteLine("IMC calculado: " + imc);

            if (imc <= 0)
            {
                Console.WriteLine("Valores inválidos");
            }

            else if (imc < 18.5)
            {
                Console.WriteLine("Abaixo do peso");
            }

            else if (imc < 25)
            {
                Console.WriteLine("Saudável");
            }

            else if (imc < 30)
            {
                Console.WriteLine("Peso em excesso");
            }

            else if (imc < 35)
            {
                Console.WriteLine("Obesidade Grau I");
            }

            else if (imc < 40)
            {
                Console.WriteLine("Obesidade Grau II");
            }

            else if (imc >= 40)
            {
                Console.WriteLine("Obesidade Garau III");
            }
        }
    }
}

