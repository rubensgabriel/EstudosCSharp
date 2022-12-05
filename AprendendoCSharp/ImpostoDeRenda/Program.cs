using System;

class Programa
{
    static void Main(string[] args)
    {
        // De 1900.0 até 2800.0 o IR é de 7.5% e pode deduzir R$ 142
        // De 2800.01 até 3751.0 o IR é de 15% e pode deduzir R$ 350
        // De 3751.01 até 4664.00 o IR é de 22.5% e pode deduzir R$ 636

        double salario = 3300.0;

        if (salario >= 1900 && salario <= 2800)
        {
            Console.WriteLine("A sua aliquota é de 7,5%");
            Console.WriteLine("Você pode deduzir até R$142,00");
        }
        else if (salario >= 2800.1 && salario <= 3751.0)
        {
            Console.WriteLine("A sua aliquota é de 15%");
            Console.WriteLine("Você pode deduzir até R$350,00");
        }
        else if (salario >= 3751.01 && salario <= 4664)
        {
            Console.WriteLine("A sua aliquota é de 22,5%");
            Console.WriteLine("Você pode deduzir até R$636,00");
        }
        else
        {
            Console.WriteLine("Valor inválido ou fora dos limites impostos");
        }
    }
}