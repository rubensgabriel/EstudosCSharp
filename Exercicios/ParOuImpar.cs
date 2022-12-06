using System;
class Programa
{
    static void Main(string[] args)
    {   
        int num;
        
        Console.WriteLine("Informe um número");
        num = Convert.ToInt32(Console.ReadLine());
        
        if (num%2 == 0)
        {
            Console.WriteLine(num + " é um número par");
        }
        else
        {
            Console.WriteLine(num + " é um número ímpar");
        }
    }
}